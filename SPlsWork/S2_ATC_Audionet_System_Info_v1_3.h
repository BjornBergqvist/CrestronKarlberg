#ifndef __S2_ATC_AUDIONET_SYSTEM_INFO_V1_3_H__
#define __S2_ATC_AUDIONET_SYSTEM_INFO_V1_3_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/


/*
* ANALOG_INPUT
*/
#define __S2_ATC_Audionet_System_Info_v1_3_SLOT_ANALOG_INPUT 0

#define __S2_ATC_Audionet_System_Info_v1_3_IPAIN$_STRING_INPUT 1
#define __S2_ATC_Audionet_System_Info_v1_3_IPAIN$_STRING_MAX_LEN 1000
CREATE_STRING_STRUCT( S2_ATC_Audionet_System_Info_v1_3, __IPAIN$, __S2_ATC_Audionet_System_Info_v1_3_IPAIN$_STRING_MAX_LEN );
#define __S2_ATC_Audionet_System_Info_v1_3_IPMIN$_STRING_INPUT 2
#define __S2_ATC_Audionet_System_Info_v1_3_IPMIN$_STRING_MAX_LEN 1000
CREATE_STRING_STRUCT( S2_ATC_Audionet_System_Info_v1_3, __IPMIN$, __S2_ATC_Audionet_System_Info_v1_3_IPMIN$_STRING_MAX_LEN );
#define __S2_ATC_Audionet_System_Info_v1_3_DEFRIN$_STRING_INPUT 3
#define __S2_ATC_Audionet_System_Info_v1_3_DEFRIN$_STRING_MAX_LEN 1000
CREATE_STRING_STRUCT( S2_ATC_Audionet_System_Info_v1_3, __DEFRIN$, __S2_ATC_Audionet_System_Info_v1_3_DEFRIN$_STRING_MAX_LEN );
#define __S2_ATC_Audionet_System_Info_v1_3_DHCPIN$_STRING_INPUT 4
#define __S2_ATC_Audionet_System_Info_v1_3_DHCPIN$_STRING_MAX_LEN 1000
CREATE_STRING_STRUCT( S2_ATC_Audionet_System_Info_v1_3, __DHCPIN$, __S2_ATC_Audionet_System_Info_v1_3_DHCPIN$_STRING_MAX_LEN );
#define __S2_ATC_Audionet_System_Info_v1_3_HOSTNAMEIN$_STRING_INPUT 5
#define __S2_ATC_Audionet_System_Info_v1_3_HOSTNAMEIN$_STRING_MAX_LEN 1000
CREATE_STRING_STRUCT( S2_ATC_Audionet_System_Info_v1_3, __HOSTNAMEIN$, __S2_ATC_Audionet_System_Info_v1_3_HOSTNAMEIN$_STRING_MAX_LEN );
#define __S2_ATC_Audionet_System_Info_v1_3_PEERIPTABLEIN$_STRING_INPUT 6
#define __S2_ATC_Audionet_System_Info_v1_3_PEERIPTABLEIN$_STRING_MAX_LEN 1000
CREATE_STRING_STRUCT( S2_ATC_Audionet_System_Info_v1_3, __PEERIPTABLEIN$, __S2_ATC_Audionet_System_Info_v1_3_PEERIPTABLEIN$_STRING_MAX_LEN );
#define __S2_ATC_Audionet_System_Info_v1_3_ADDDNS$_STRING_INPUT 7
#define __S2_ATC_Audionet_System_Info_v1_3_ADDDNS$_STRING_MAX_LEN 15
CREATE_STRING_STRUCT( S2_ATC_Audionet_System_Info_v1_3, __ADDDNS$, __S2_ATC_Audionet_System_Info_v1_3_ADDDNS$_STRING_MAX_LEN );
#define __S2_ATC_Audionet_System_Info_v1_3_REMOVEDNS$_STRING_INPUT 8
#define __S2_ATC_Audionet_System_Info_v1_3_REMOVEDNS$_STRING_MAX_LEN 15
CREATE_STRING_STRUCT( S2_ATC_Audionet_System_Info_v1_3, __REMOVEDNS$, __S2_ATC_Audionet_System_Info_v1_3_REMOVEDNS$_STRING_MAX_LEN );

#define __S2_ATC_Audionet_System_Info_v1_3_FROMCONSOLE$_BUFFER_INPUT 9
#define __S2_ATC_Audionet_System_Info_v1_3_FROMCONSOLE$_BUFFER_MAX_LEN 1000
CREATE_STRING_STRUCT( S2_ATC_Audionet_System_Info_v1_3, __FROMCONSOLE$, __S2_ATC_Audionet_System_Info_v1_3_FROMCONSOLE$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/
#define __S2_ATC_Audionet_System_Info_v1_3_BUSY_DIG_OUTPUT 0
#define __S2_ATC_Audionet_System_Info_v1_3_ERROR_DIG_OUTPUT 1
#define __S2_ATC_Audionet_System_Info_v1_3_DNSUPDATECOMPLETE_DIG_OUTPUT 2
#define __S2_ATC_Audionet_System_Info_v1_3_DNSUPDATEINPROGRESS_DIG_OUTPUT 3


/*
* ANALOG_OUTPUT
*/
#define __S2_ATC_Audionet_System_Info_v1_3_PROGRESS_ANALOG_OUTPUT 0

#define __S2_ATC_Audionet_System_Info_v1_3_OPS$_STRING_OUTPUT 1
#define __S2_ATC_Audionet_System_Info_v1_3_IPA$_STRING_OUTPUT 2
#define __S2_ATC_Audionet_System_Info_v1_3_IPM$_STRING_OUTPUT 3
#define __S2_ATC_Audionet_System_Info_v1_3_DEFR$_STRING_OUTPUT 4
#define __S2_ATC_Audionet_System_Info_v1_3_DHCP$_STRING_OUTPUT 5
#define __S2_ATC_Audionet_System_Info_v1_3_MAC$_STRING_OUTPUT 6
#define __S2_ATC_Audionet_System_Info_v1_3_HOSTNAME$_STRING_OUTPUT 7
#define __S2_ATC_Audionet_System_Info_v1_3_PEERIPID$_STRING_OUTPUT 8
#define __S2_ATC_Audionet_System_Info_v1_3_PEERIPA$_STRING_OUTPUT 9
#define __S2_ATC_Audionet_System_Info_v1_3_TOCONSOLE$_STRING_OUTPUT 10

#define __S2_ATC_Audionet_System_Info_v1_3_DNS$_STRING_OUTPUT 11
#define __S2_ATC_Audionet_System_Info_v1_3_DNS$_ARRAY_LENGTH 8

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
#define __S2_ATC_Audionet_System_Info_v1_3_TEMPSTRING$_STRING_MAX_LEN 200
CREATE_STRING_STRUCT( S2_ATC_Audionet_System_Info_v1_3, __TEMPSTRING$, __S2_ATC_Audionet_System_Info_v1_3_TEMPSTRING$_STRING_MAX_LEN );
#define __S2_ATC_Audionet_System_Info_v1_3_MATCH$_STRING_MAX_LEN 10
CREATE_STRING_STRUCT( S2_ATC_Audionet_System_Info_v1_3, __MATCH$, __S2_ATC_Audionet_System_Info_v1_3_MATCH$_STRING_MAX_LEN );
#define __S2_ATC_Audionet_System_Info_v1_3_MATCH2$_STRING_MAX_LEN 6
CREATE_STRING_STRUCT( S2_ATC_Audionet_System_Info_v1_3, __MATCH2$, __S2_ATC_Audionet_System_Info_v1_3_MATCH2$_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_ATC_Audionet_System_Info_v1_3 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __DNS$ );
   unsigned short __MARKER1;
   unsigned short __MARKER2;
   unsigned short __MARKER3;
   unsigned short __SEMAPHORE;
   unsigned short __COUNTER;
   unsigned short __BUSYINT;
   unsigned short __COUNT;
   unsigned short __DNSCOUNTER;
   unsigned short __DNSUPDATEFLAG;
   DECLARE_STRING_STRUCT( S2_ATC_Audionet_System_Info_v1_3, __TEMPSTRING$ );
   DECLARE_STRING_STRUCT( S2_ATC_Audionet_System_Info_v1_3, __MATCH$ );
   DECLARE_STRING_STRUCT( S2_ATC_Audionet_System_Info_v1_3, __MATCH2$ );
   DECLARE_STRING_STRUCT( S2_ATC_Audionet_System_Info_v1_3, __IPAIN$ );
   DECLARE_STRING_STRUCT( S2_ATC_Audionet_System_Info_v1_3, __IPMIN$ );
   DECLARE_STRING_STRUCT( S2_ATC_Audionet_System_Info_v1_3, __DEFRIN$ );
   DECLARE_STRING_STRUCT( S2_ATC_Audionet_System_Info_v1_3, __DHCPIN$ );
   DECLARE_STRING_STRUCT( S2_ATC_Audionet_System_Info_v1_3, __HOSTNAMEIN$ );
   DECLARE_STRING_STRUCT( S2_ATC_Audionet_System_Info_v1_3, __PEERIPTABLEIN$ );
   DECLARE_STRING_STRUCT( S2_ATC_Audionet_System_Info_v1_3, __ADDDNS$ );
   DECLARE_STRING_STRUCT( S2_ATC_Audionet_System_Info_v1_3, __REMOVEDNS$ );
   DECLARE_STRING_STRUCT( S2_ATC_Audionet_System_Info_v1_3, __FROMCONSOLE$ );
};

START_NVRAM_VAR_STRUCT( S2_ATC_Audionet_System_Info_v1_3 )
{
};

DEFINE_WAITEVENT( S2_ATC_Audionet_System_Info_v1_3, PEERIPADDRESSWAIT );
DEFINE_WAITEVENT( S2_ATC_Audionet_System_Info_v1_3, PEERIPIDWAIT );
DEFINE_WAITEVENT( S2_ATC_Audionet_System_Info_v1_3, __SPLS_TMPVAR__WAITLABEL_0__ );


#endif //__S2_ATC_AUDIONET_SYSTEM_INFO_V1_3_H__

