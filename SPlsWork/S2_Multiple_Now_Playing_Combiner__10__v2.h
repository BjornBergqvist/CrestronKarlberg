#ifndef __S2_MULTIPLE_NOW_PLAYING_COMBINER__10__V2_H__
#define __S2_MULTIPLE_NOW_PLAYING_COMBINER__10__V2_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Multiple_Now_Playing_Combiner__10__v2_SYSTEMINITIALIZED_DIG_INPUT 0


/*
* ANALOG_INPUT
*/



#define __S2_Multiple_Now_Playing_Combiner__10__v2_LINE1$_STRING_INPUT 0
#define __S2_Multiple_Now_Playing_Combiner__10__v2_LINE1$_ARRAY_NUM_ELEMS 10
#define __S2_Multiple_Now_Playing_Combiner__10__v2_LINE1$_ARRAY_NUM_CHARS 100
CREATE_STRING_ARRAY( S2_Multiple_Now_Playing_Combiner__10__v2, __LINE1$, __S2_Multiple_Now_Playing_Combiner__10__v2_LINE1$_ARRAY_NUM_ELEMS, __S2_Multiple_Now_Playing_Combiner__10__v2_LINE1$_ARRAY_NUM_CHARS );
#define __S2_Multiple_Now_Playing_Combiner__10__v2_LINE2$_STRING_INPUT 10
#define __S2_Multiple_Now_Playing_Combiner__10__v2_LINE2$_ARRAY_NUM_ELEMS 10
#define __S2_Multiple_Now_Playing_Combiner__10__v2_LINE2$_ARRAY_NUM_CHARS 100
CREATE_STRING_ARRAY( S2_Multiple_Now_Playing_Combiner__10__v2, __LINE2$, __S2_Multiple_Now_Playing_Combiner__10__v2_LINE2$_ARRAY_NUM_ELEMS, __S2_Multiple_Now_Playing_Combiner__10__v2_LINE2$_ARRAY_NUM_CHARS );
#define __S2_Multiple_Now_Playing_Combiner__10__v2_TRANSPORT$_STRING_INPUT 20
#define __S2_Multiple_Now_Playing_Combiner__10__v2_TRANSPORT$_ARRAY_NUM_ELEMS 10
#define __S2_Multiple_Now_Playing_Combiner__10__v2_TRANSPORT$_ARRAY_NUM_CHARS 1
CREATE_STRING_ARRAY( S2_Multiple_Now_Playing_Combiner__10__v2, __TRANSPORT$, __S2_Multiple_Now_Playing_Combiner__10__v2_TRANSPORT$_ARRAY_NUM_ELEMS, __S2_Multiple_Now_Playing_Combiner__10__v2_TRANSPORT$_ARRAY_NUM_CHARS );

/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/


#define __S2_Multiple_Now_Playing_Combiner__10__v2_NOWPLAYING$_STRING_OUTPUT 0
#define __S2_Multiple_Now_Playing_Combiner__10__v2_NOWPLAYING$_ARRAY_LENGTH 10

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

START_GLOBAL_VAR_STRUCT( S2_Multiple_Now_Playing_Combiner__10__v2 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __NOWPLAYING$ );
   unsigned short __SYSTEMREADY;
   DECLARE_STRING_ARRAY( S2_Multiple_Now_Playing_Combiner__10__v2, __LINE1$ );
   DECLARE_STRING_ARRAY( S2_Multiple_Now_Playing_Combiner__10__v2, __LINE2$ );
   DECLARE_STRING_ARRAY( S2_Multiple_Now_Playing_Combiner__10__v2, __TRANSPORT$ );
};

START_NVRAM_VAR_STRUCT( S2_Multiple_Now_Playing_Combiner__10__v2 )
{
};



#endif //__S2_MULTIPLE_NOW_PLAYING_COMBINER__10__V2_H__

