//  Project  : ACTORS
//  Contacts : Pixeye - ask@pixeye.games

using System.Collections.Generic;
 

namespace Pixeye.Actors{

 
///<summary>
/// Mutable String class, optimized for speed and memory allocations while retrieving the final result as a string.
/// Similar use than StringBuilder, but avoid a lot of allocations done by StringBuilder (conversion of int and float to string, frequent capacity change, etc.)
/// Author: Nicolas Gadenne contact@gaddygames.com
///</summary>
public class FastString
{
    ///<summary>Immutable string. Generated at last moment, only if needed</summary>
    private string m_stringGenerated = "";
    ///<summary>Is m_stringGenerated is up to date ?</summary>
    private bool m_isStringGenerated = false;

    ///<summary>Working mutable string</summary>
    private char[] m_buffer = null;
    private int m_bufferPos = 0;
    private int m_charsCapacity = 0;

    ///<summary>Temporary string used for the Replace method</summary>
    private List<char> m_replacement = null;

    private object m_valueControl = null;
    private int m_valueControlInt = int.MinValue;

    public FastString( int initialCapacity = 32 )
    {
        m_buffer = new char[ m_charsCapacity = initialCapacity ];
    }

    public bool IsEmpty()
    {
        return (m_isStringGenerated ? (m_stringGenerated == null) : (m_bufferPos == 0));
    }

    ///<summary>Return the string</summary>
    public override string ToString()
    {
        if( !m_isStringGenerated ) // Regenerate the immutable string if needed
        {
            m_stringGenerated = new string( m_buffer, 0, m_bufferPos );
            m_isStringGenerated = true;
        }
        return m_stringGenerated;
    }

    // Value controls methods: use a value to check if the string has to be regenerated.

    ///<summary>Return true if the valueControl has changed (and update it)</summary>
    public bool IsModified( int newControlValue )
    {
        bool changed = (newControlValue != m_valueControlInt);
        if( changed )
            m_valueControlInt = newControlValue;
        return changed;
    }

    ///<summary>Return true if the valueControl has changed (and update it)</summary>
    public bool IsModified( object newControlValue )
    {
        bool changed = !(newControlValue.Equals( m_valueControl ));
        if( changed )
            m_valueControl = newControlValue;
        return changed;
    }

    // Set methods: 

    ///<summary>Set a string, no memorry allocation</summary>
    public void Set( string str )
    {
        // We fill the m_chars list to manage future appends, but we also directly set the final stringGenerated
        Clear();
        Append( str );
        m_stringGenerated = str;
        m_isStringGenerated = true;
    }
    ///<summary>Caution, allocate some memory</summary>
    public void Set( object str )
    {
        Set( str.ToString() );
    }

    ///<summary>Append several params: no memory allocation unless params are of object type</summary>
    public void Set<T1, T2>( T1 str1, T2 str2 )
    {
        Clear();
        Append( str1 ); Append( str2 );
    }
    public void Set<T1, T2, T3>( T1 str1, T2 str2, T3 str3 )
    {
        Clear();
        Append( str1 ); Append( str2 ); Append( str3 );
    }
    public void Set<T1, T2, T3, T4>( T1 str1, T2 str2, T3 str3, T4 str4 )
    {
        Clear();
        Append( str1 ); Append( str2 ); Append( str3 ); Append( str4 );
    }
    ///<summary>Allocate a little memory (20 byte)</summary>
    public void Set( params object[] str )
    {
        Clear();
        for( int i=0; i<str.Length; i++ )
            Append( str[ i ] );
    }

    // Append methods, to build the string without allocation

    ///<summary>Reset the m_char array</summary>
    public FastString Clear()
    {
        m_bufferPos = 0;
        m_isStringGenerated = false;
        return this;
    }

    ///<summary>Append a string without memory allocation</summary>
    public FastString Append( string value )
    {
        ReallocateIFN( value.Length );
        int n = value.Length;
        for( int i=0; i<n; i++ )
            m_buffer[ m_bufferPos + i ] = value[ i ];
        m_bufferPos += n;
        m_isStringGenerated = false;
        return this;
    }
    ///<summary>Append an object.ToString(), allocate some memory</summary>
    public FastString Append( object value )
    {
        Append( value.ToString() );
        return this;
    }

    ///<summary>Append an int without memory allocation</summary>
    public FastString Append( int value )
    {
        // Allocate enough memory to handle any int number
        ReallocateIFN( 16 );

        // Handle the negative case
        if( value < 0 )
        {
            value = -value;
            m_buffer[ m_bufferPos++ ] = '-';
        }

        // Copy the digits in reverse order
        int nbChars = 0;
        do
        {
            m_buffer[ m_bufferPos++ ] = (char)('0' + value%10);
            value /= 10;
            nbChars++;
        } while( value != 0 );

        // Reverse the result
        for( int i=nbChars/2-1; i>=0; i-- )
        {
            char c = m_buffer[ m_bufferPos-i-1 ];
            m_buffer[ m_bufferPos-i-1 ] = m_buffer[ m_bufferPos-nbChars+i ];
            m_buffer[ m_bufferPos-nbChars+i ] = c;
        }
        m_isStringGenerated = false;
        return this;
    }

    ///<summary>Append a float without memory allocation.</summary>
    public FastString Append( float valueF )
    {
        double value = valueF;
        m_isStringGenerated = false;
        ReallocateIFN( 32 ); // Check we have enough buffer allocated to handle any float number

        // Handle the 0 case
        if( value == 0 )
        {
            m_buffer[ m_bufferPos++ ] = '0';
            return this;
        }

        // Handle the negative case
        if( value < 0 )
        {
            value = -value;
            m_buffer[ m_bufferPos++ ] = '-';
        }

        // Get the 7 meaningful digits as a long
        int nbDecimals = 0;
        while( value < 1000000 )
        {
            value *= 10;
            nbDecimals++;
        }
        long valueLong = (long)System.Math.Round( value );

        // Parse the number in reverse order
        int nbChars = 0;
        bool isLeadingZero = true;
        while( valueLong != 0 || nbDecimals >= 0 )
        {
            // We stop removing leading 0 when non-0 or decimal digit
            if( valueLong%10 != 0 || nbDecimals <= 0 )
                isLeadingZero = false;

            // Write the last digit (unless a leading zero)
            if( !isLeadingZero )
                m_buffer[ m_bufferPos + (nbChars++) ] = (char)('0' + valueLong%10);

            // Add the decimal point
            if( --nbDecimals == 0 && !isLeadingZero )
                m_buffer[ m_bufferPos + (nbChars++) ] = '.';

            valueLong /= 10;
        }
        m_bufferPos += nbChars;
        
        // Reverse the result
        for( int i=nbChars/2-1; i>=0; i-- )
        {
            char c = m_buffer[ m_bufferPos-i-1 ];
            m_buffer[ m_bufferPos-i-1 ] = m_buffer[ m_bufferPos-nbChars+i ];
            m_buffer[ m_bufferPos-nbChars+i ] = c;
        }

        return this;
    }

    ///<summary>Replace all occurences of a string by another one</summary>
    public FastString Replace( string oldStr, string newStr )
    {
        if( m_bufferPos == 0 )
            return this;

        if( m_replacement == null )
            m_replacement = new List<char>();

        // Create the new string into m_replacement
        for( int i=0; i<m_bufferPos; i++ )
        {
            bool isToReplace = false;
            if( m_buffer[ i ] == oldStr[ 0 ] ) // If first character found, check for the rest of the string to replace
            {
                int k=1;
                while( k < oldStr.Length && m_buffer[ i+k ] == oldStr[ k ] )
                    k++;
                isToReplace = (k >= oldStr.Length);
            }
            if( isToReplace ) // Do the replacement
            {
                i += oldStr.Length-1;
                if (newStr == null) continue;
                for( int k=0; k<newStr.Length; k++ )
                    m_replacement.Add( newStr[ k ] );
            }
            else // No replacement, copy the old character
                m_replacement.Add( m_buffer[ i ] );
        }

        // Copy back the new string into m_chars
        ReallocateIFN( m_replacement.Count - m_bufferPos );
        for( int k=0; k<m_replacement.Count; k++ )
            m_buffer[ k ] = m_replacement[ k ];
        m_bufferPos = m_replacement.Count;
        m_replacement.Clear();
        m_isStringGenerated = false;
        return this;
    }

    private void ReallocateIFN( int nbCharsToAdd )
    {
        if( m_bufferPos + nbCharsToAdd > m_charsCapacity )
        {
            m_charsCapacity = System.Math.Max( m_charsCapacity + nbCharsToAdd, m_charsCapacity * 2 );
            var newChars = new char[ m_charsCapacity ];
            m_buffer.CopyTo( newChars, 0 );
            m_buffer = newChars;
        }
    }
}

}