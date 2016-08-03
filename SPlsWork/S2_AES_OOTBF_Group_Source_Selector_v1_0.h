#ifndef __S2_AES_OOTBF_GROUP_SOURCE_SELECTOR_V1_0_H__
#define __S2_AES_OOTBF_GROUP_SOURCE_SELECTOR_V1_0_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_AES_OOTBF_Group_Source_Selector_v1_0_FIRST_DIG_INPUT 0
#define __S2_AES_OOTBF_Group_Source_Selector_v1_0_NEXT_DIG_INPUT 1
#define __S2_AES_OOTBF_Group_Source_Selector_v1_0_PREVIOUS_DIG_INPUT 2
#define __S2_AES_OOTBF_Group_Source_Selector_v1_0_REFRESH_DIG_INPUT 3
#define __S2_AES_OOTBF_Group_Source_Selector_v1_0_EDITACTIVE_DIG_INPUT 4

#define __S2_AES_OOTBF_Group_Source_Selector_v1_0_SOURCEDISABLED_DIG_INPUT 5
#define __S2_AES_OOTBF_Group_Source_Selector_v1_0_SOURCEDISABLED_ARRAY_LENGTH 10

/*
* ANALOG_INPUT
*/
#define __S2_AES_OOTBF_Group_Source_Selector_v1_0_SOURCEACTIVE_ANALOG_INPUT 0



#define __S2_AES_OOTBF_Group_Source_Selector_v1_0_SOURCETYPE_ANALOG_INPUT 1
#define __S2_AES_OOTBF_Group_Source_Selector_v1_0_SOURCETYPE_ARRAY_LENGTH 10
#define __S2_AES_OOTBF_Group_Source_Selector_v1_0_SOURCENAME$_STRING_INPUT 11
#define __S2_AES_OOTBF_Group_Source_Selector_v1_0_SOURCENAME$_ARRAY_NUM_ELEMS 10
#define __S2_AES_OOTBF_Group_Source_Selector_v1_0_SOURCENAME$_ARRAY_NUM_CHARS 24
CREATE_STRING_ARRAY( S2_AES_OOTBF_Group_Source_Selector_v1_0, __SOURCENAME$, __S2_AES_OOTBF_Group_Source_Selector_v1_0_SOURCENAME$_ARRAY_NUM_ELEMS, __S2_AES_OOTBF_Group_Source_Selector_v1_0_SOURCENAME$_ARRAY_NUM_CHARS );

/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/
#define __S2_AES_OOTBF_Group_Source_Selector_v1_0_SOURCEOUT_ANALOG_OUTPUT 0
#define __S2_AES_OOTBF_Group_Source_Selector_v1_0_SOURCETYPEOUT_ANALOG_OUTPUT 1
#define __S2_AES_OOTBF_Group_Source_Selector_v1_0_NOWPLAYINGINDEX_ANALOG_OUTPUT 2

#define __S2_AES_OOTBF_Group_Source_Selector_v1_0_SOURCENAMEOUT$_STRING_OUTPUT 3


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

START_GLOBAL_VAR_STRUCT( S2_AES_OOTBF_Group_Source_Selector_v1_0 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __SOURCEDISABLED );
   DECLARE_IO_ARRAY( __SOURCETYPE );
   unsigned short __G_IINDEX;
   DECLARE_STRING_ARRAY( S2_AES_OOTBF_Group_Source_Selector_v1_0, __SOURCENAME$ );
};

START_NVRAM_VAR_STRUCT( S2_AES_OOTBF_Group_Source_Selector_v1_0 )
{
};



#endif //__S2_AES_OOTBF_GROUP_SOURCE_SELECTOR_V1_0_H__

