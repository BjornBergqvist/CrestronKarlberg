#ifndef __S2_ADAGIO_OOTBF_PRIORITY_PROCESSOR_V1_H__
#define __S2_ADAGIO_OOTBF_PRIORITY_PROCESSOR_V1_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/

#define __S2_Adagio_OOTBF_Priority_Processor_v1_GROUPACTIVE_DIG_INPUT 0
#define __S2_Adagio_OOTBF_Priority_Processor_v1_GROUPACTIVE_ARRAY_LENGTH 6

/*
* ANALOG_INPUT
*/



#define __S2_Adagio_OOTBF_Priority_Processor_v1_GROUPROOMSLOW_ANALOG_INPUT 0
#define __S2_Adagio_OOTBF_Priority_Processor_v1_GROUPROOMSLOW_ARRAY_LENGTH 6
#define __S2_Adagio_OOTBF_Priority_Processor_v1_GROUPROOMSHIGH_ANALOG_INPUT 6
#define __S2_Adagio_OOTBF_Priority_Processor_v1_GROUPROOMSHIGH_ARRAY_LENGTH 6
#define __S2_Adagio_OOTBF_Priority_Processor_v1_CURRENTROOMSOURCE_ANALOG_INPUT 12
#define __S2_Adagio_OOTBF_Priority_Processor_v1_CURRENTROOMSOURCE_ARRAY_LENGTH 24
#define __S2_Adagio_OOTBF_Priority_Processor_v1_SOURCECONTROLREQUEST_ANALOG_INPUT 36
#define __S2_Adagio_OOTBF_Priority_Processor_v1_SOURCECONTROLREQUEST_ARRAY_LENGTH 24
#define __S2_Adagio_OOTBF_Priority_Processor_v1_SOURCECONTROLOVERRIDE_ANALOG_INPUT 60
#define __S2_Adagio_OOTBF_Priority_Processor_v1_SOURCECONTROLOVERRIDE_ARRAY_LENGTH 24

/*
* DIGITAL_OUTPUT
*/

#define __S2_Adagio_OOTBF_Priority_Processor_v1_CONTROLOK_DIG_OUTPUT 0
#define __S2_Adagio_OOTBF_Priority_Processor_v1_CONTROLOK_ARRAY_LENGTH 24
#define __S2_Adagio_OOTBF_Priority_Processor_v1_CONTROLFAILED_DIG_OUTPUT 24
#define __S2_Adagio_OOTBF_Priority_Processor_v1_CONTROLFAILED_ARRAY_LENGTH 24
#define __S2_Adagio_OOTBF_Priority_Processor_v1_CONTROLREMOVED_DIG_OUTPUT 48
#define __S2_Adagio_OOTBF_Priority_Processor_v1_CONTROLREMOVED_ARRAY_LENGTH 24

/*
* ANALOG_OUTPUT
*/


#define __S2_Adagio_OOTBF_Priority_Processor_v1_SOURCEOWNER_ANALOG_OUTPUT 0
#define __S2_Adagio_OOTBF_Priority_Processor_v1_SOURCEOWNER_ARRAY_LENGTH 10

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

START_GLOBAL_VAR_STRUCT( S2_Adagio_OOTBF_Priority_Processor_v1 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __GROUPACTIVE );
   DECLARE_IO_ARRAY( __CONTROLOK );
   DECLARE_IO_ARRAY( __CONTROLFAILED );
   DECLARE_IO_ARRAY( __CONTROLREMOVED );
   DECLARE_IO_ARRAY( __GROUPROOMSLOW );
   DECLARE_IO_ARRAY( __GROUPROOMSHIGH );
   DECLARE_IO_ARRAY( __CURRENTROOMSOURCE );
   DECLARE_IO_ARRAY( __SOURCECONTROLREQUEST );
   DECLARE_IO_ARRAY( __SOURCECONTROLOVERRIDE );
   DECLARE_IO_ARRAY( __SOURCEOWNER );
};

START_NVRAM_VAR_STRUCT( S2_Adagio_OOTBF_Priority_Processor_v1 )
{
};



#endif //__S2_ADAGIO_OOTBF_PRIORITY_PROCESSOR_V1_H__

