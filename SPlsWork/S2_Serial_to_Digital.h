#ifndef __S2_SERIAL_TO_DIGITAL_H__
#define __S2_SERIAL_TO_DIGITAL_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/


/*
* ANALOG_INPUT
*/

#define __S2_Serial_to_Digital_ASTRING_STRING_INPUT 0
#define __S2_Serial_to_Digital_ASTRING_STRING_MAX_LEN 250
CREATE_STRING_STRUCT( S2_Serial_to_Digital, __ASTRING, __S2_Serial_to_Digital_ASTRING_STRING_MAX_LEN );



/*
* DIGITAL_OUTPUT
*/
#define __S2_Serial_to_Digital_ASTRING_IS_POPULATED_DIG_OUTPUT 0


/*
* ANALOG_OUTPUT
*/



/*
* Direct Socket Variables
*/




/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* STRING_PARAMETER
*/


/*
* INTEGER
*/


/*
* LONG_INTEGER
*/


/*
* SIGNED_INTEGER
*/


/*
* SIGNED_LONG_INTEGER
*/


/*
* STRING
*/

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Serial_to_Digital )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   unsigned short __SEMA4;
   DECLARE_STRING_STRUCT( S2_Serial_to_Digital, __ASTRING );
};

START_NVRAM_VAR_STRUCT( S2_Serial_to_Digital )
{
};

DEFINE_WAITEVENT( S2_Serial_to_Digital, W_ASTRING );


#endif //__S2_SERIAL_TO_DIGITAL_H__

