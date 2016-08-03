#ifndef __S2_INSTALLER_TOOLS___AUDIONET_SETUP_V4_H__
#define __S2_INSTALLER_TOOLS___AUDIONET_SETUP_V4_H__



/*
* STRUCTURE S2_Installer_Tools___AudioNet_Setup_v4__STACK
*/
START_STRUCTURE_DEFINITION( S2_Installer_Tools___AudioNet_Setup_v4, STACK )
{
   unsigned short STACK__STACKMENU;
   unsigned short STACK__STACKINDEX;
   unsigned short STACK__STACKHIGHLIGHT;
};


/*
* Constructor and Destructor
*/
int S2_Installer_Tools___AudioNet_Setup_v4_STACK_Constructor ( START_STRUCTURE_DEFINITION( S2_Installer_Tools___AudioNet_Setup_v4, STACK ) * me, int nVerbose );
int S2_Installer_Tools___AudioNet_Setup_v4_STACK_Destructor ( START_STRUCTURE_DEFINITION( S2_Installer_Tools___AudioNet_Setup_v4, STACK ) * me, int nVerbose );

/*
* DIGITAL_INPUT
*/
#define __S2_Installer_Tools___AudioNet_Setup_v4_ENABLE_DIG_INPUT 0
#define __S2_Installer_Tools___AudioNet_Setup_v4_KNOBLEFT_DIG_INPUT 1
#define __S2_Installer_Tools___AudioNet_Setup_v4_KNOBRIGHT_DIG_INPUT 2
#define __S2_Installer_Tools___AudioNet_Setup_v4_ENTER_DIG_INPUT 3
#define __S2_Installer_Tools___AudioNet_Setup_v4_MENU_DIG_INPUT 4
#define __S2_Installer_Tools___AudioNet_Setup_v4_ACCELERATEDKNOBENABLE_DIG_INPUT 5
#define __S2_Installer_Tools___AudioNet_Setup_v4_REBOOTCOMPLETE_DIG_INPUT 6
#define __S2_Installer_Tools___AudioNet_Setup_v4_RETRIEVALCOMPLETE_DIG_INPUT 7
#define __S2_Installer_Tools___AudioNet_Setup_v4_DNSUPDATECOMPLETE_DIG_INPUT 8

#define __S2_Installer_Tools___AudioNet_Setup_v4_SOFTKEY_DIG_INPUT 9
#define __S2_Installer_Tools___AudioNet_Setup_v4_SOFTKEY_ARRAY_LENGTH 4

/*
* ANALOG_INPUT
*/
#define __S2_Installer_Tools___AudioNet_Setup_v4_KNOBPKTDELTA_ANALOG_INPUT 0
#define __S2_Installer_Tools___AudioNet_Setup_v4_KNOBPKTTIME_ANALOG_INPUT 1
#define __S2_Installer_Tools___AudioNet_Setup_v4_SLOWTURNHSEC_ANALOG_INPUT 2
#define __S2_Installer_Tools___AudioNet_Setup_v4_SLOWTURNINCREMENT_ANALOG_INPUT 3
#define __S2_Installer_Tools___AudioNet_Setup_v4_FASTTURNHSEC_ANALOG_INPUT 4
#define __S2_Installer_Tools___AudioNet_Setup_v4_FASTTURNINCREMENT_ANALOG_INPUT 5
#define __S2_Installer_Tools___AudioNet_Setup_v4_SLOT_ANALOG_INPUT 6

#define __S2_Installer_Tools___AudioNet_Setup_v4_ACCELERATEDKNOBTRIG_STRING_INPUT 7
#define __S2_Installer_Tools___AudioNet_Setup_v4_ACCELERATEDKNOBTRIG_STRING_MAX_LEN 1
CREATE_STRING_STRUCT( S2_Installer_Tools___AudioNet_Setup_v4, __ACCELERATEDKNOBTRIG, __S2_Installer_Tools___AudioNet_Setup_v4_ACCELERATEDKNOBTRIG_STRING_MAX_LEN );
#define __S2_Installer_Tools___AudioNet_Setup_v4_MACADDRESSIN$_STRING_INPUT 8
#define __S2_Installer_Tools___AudioNet_Setup_v4_MACADDRESSIN$_STRING_MAX_LEN 17
CREATE_STRING_STRUCT( S2_Installer_Tools___AudioNet_Setup_v4, __MACADDRESSIN$, __S2_Installer_Tools___AudioNet_Setup_v4_MACADDRESSIN$_STRING_MAX_LEN );
#define __S2_Installer_Tools___AudioNet_Setup_v4_HOSTNAMEIN$_STRING_INPUT 9
#define __S2_Installer_Tools___AudioNet_Setup_v4_HOSTNAMEIN$_STRING_MAX_LEN 64
CREATE_STRING_STRUCT( S2_Installer_Tools___AudioNet_Setup_v4, __HOSTNAMEIN$, __S2_Installer_Tools___AudioNet_Setup_v4_HOSTNAMEIN$_STRING_MAX_LEN );
#define __S2_Installer_Tools___AudioNet_Setup_v4_EDITEDHOSTNAMEIN$_STRING_INPUT 10
#define __S2_Installer_Tools___AudioNet_Setup_v4_EDITEDHOSTNAMEIN$_STRING_MAX_LEN 64
CREATE_STRING_STRUCT( S2_Installer_Tools___AudioNet_Setup_v4, __EDITEDHOSTNAMEIN$, __S2_Installer_Tools___AudioNet_Setup_v4_EDITEDHOSTNAMEIN$_STRING_MAX_LEN );


#define __S2_Installer_Tools___AudioNet_Setup_v4_SYSTEMINFO$_STRING_INPUT 11
#define __S2_Installer_Tools___AudioNet_Setup_v4_SYSTEMINFO$_ARRAY_NUM_ELEMS 6
#define __S2_Installer_Tools___AudioNet_Setup_v4_SYSTEMINFO$_ARRAY_NUM_CHARS 15
CREATE_STRING_ARRAY( S2_Installer_Tools___AudioNet_Setup_v4, __SYSTEMINFO$, __S2_Installer_Tools___AudioNet_Setup_v4_SYSTEMINFO$_ARRAY_NUM_ELEMS, __S2_Installer_Tools___AudioNet_Setup_v4_SYSTEMINFO$_ARRAY_NUM_CHARS );
#define __S2_Installer_Tools___AudioNet_Setup_v4_DNS$_STRING_INPUT 17
#define __S2_Installer_Tools___AudioNet_Setup_v4_DNS$_ARRAY_NUM_ELEMS 8
#define __S2_Installer_Tools___AudioNet_Setup_v4_DNS$_ARRAY_NUM_CHARS 15
CREATE_STRING_ARRAY( S2_Installer_Tools___AudioNet_Setup_v4, __DNS$, __S2_Installer_Tools___AudioNet_Setup_v4_DNS$_ARRAY_NUM_ELEMS, __S2_Installer_Tools___AudioNet_Setup_v4_DNS$_ARRAY_NUM_CHARS );

/*
* DIGITAL_OUTPUT
*/
#define __S2_Installer_Tools___AudioNet_Setup_v4_EXIT_DIG_OUTPUT 0
#define __S2_Installer_Tools___AudioNet_Setup_v4_REBOOTNEEDED_DIG_OUTPUT 1
#define __S2_Installer_Tools___AudioNet_Setup_v4_NEWPEERIPTABLENEEDED_DIG_OUTPUT 2
#define __S2_Installer_Tools___AudioNet_Setup_v4_REBOOTING_DIG_OUTPUT 3

#define __S2_Installer_Tools___AudioNet_Setup_v4_SCROLLLISTHIGHLIGHT_DIG_OUTPUT 4
#define __S2_Installer_Tools___AudioNet_Setup_v4_SCROLLLISTHIGHLIGHT_ARRAY_LENGTH 3
#define __S2_Installer_Tools___AudioNet_Setup_v4_SCROLLLISTINDICATOR_DIG_OUTPUT 7
#define __S2_Installer_Tools___AudioNet_Setup_v4_SCROLLLISTINDICATOR_ARRAY_LENGTH 3

/*
* ANALOG_OUTPUT
*/
#define __S2_Installer_Tools___AudioNet_Setup_v4_CURRENTMENU_ANALOG_OUTPUT 0
#define __S2_Installer_Tools___AudioNet_Setup_v4_SCROLLLISTSCROLLBAR_ANALOG_OUTPUT 1

#define __S2_Installer_Tools___AudioNet_Setup_v4_NEWHOSTNAME$_STRING_OUTPUT 2
#define __S2_Installer_Tools___AudioNet_Setup_v4_HOSTNAMETOEDIT$_STRING_OUTPUT 3
#define __S2_Installer_Tools___AudioNet_Setup_v4_PEERIPIDOUT$_STRING_OUTPUT 4
#define __S2_Installer_Tools___AudioNet_Setup_v4_CONSOLETX$_STRING_OUTPUT 5
#define __S2_Installer_Tools___AudioNet_Setup_v4_SCROLLLISTTITLE$_STRING_OUTPUT 6
#define __S2_Installer_Tools___AudioNet_Setup_v4_REMOVEDNS$_STRING_OUTPUT 7
#define __S2_Installer_Tools___AudioNet_Setup_v4_ADDDNS$_STRING_OUTPUT 8

#define __S2_Installer_Tools___AudioNet_Setup_v4_SCROLLLIST$_STRING_OUTPUT 9
#define __S2_Installer_Tools___AudioNet_Setup_v4_SCROLLLIST$_ARRAY_LENGTH 3
#define __S2_Installer_Tools___AudioNet_Setup_v4_SOFTKEY$_STRING_OUTPUT 12
#define __S2_Installer_Tools___AudioNet_Setup_v4_SOFTKEY$_ARRAY_LENGTH 4
#define __S2_Installer_Tools___AudioNet_Setup_v4_SYSTEMINFOOUT$_STRING_OUTPUT 16
#define __S2_Installer_Tools___AudioNet_Setup_v4_SYSTEMINFOOUT$_ARRAY_LENGTH 5

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
CREATE_INTARRAY1D( S2_Installer_Tools___AudioNet_Setup_v4, __IPFLAG, 7 );;

CREATE_INTARRAY2D( S2_Installer_Tools___AudioNet_Setup_v4, __ORIGINALOCTET, 8, 4 );;
CREATE_INTARRAY2D( S2_Installer_Tools___AudioNet_Setup_v4, __TEMPOCTET, 8, 4 );;
CREATE_INTARRAY2D( S2_Installer_Tools___AudioNet_Setup_v4, __NEWOCTET, 8, 4 );;

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
#define __S2_Installer_Tools___AudioNet_Setup_v4_HOSTNAMETEMP$_STRING_MAX_LEN 64
CREATE_STRING_STRUCT( S2_Installer_Tools___AudioNet_Setup_v4, __HOSTNAMETEMP$, __S2_Installer_Tools___AudioNet_Setup_v4_HOSTNAMETEMP$_STRING_MAX_LEN );
#define __S2_Installer_Tools___AudioNet_Setup_v4_OLDPEERIPTABLE$_STRING_MAX_LEN 60
CREATE_STRING_STRUCT( S2_Installer_Tools___AudioNet_Setup_v4, __OLDPEERIPTABLE$, __S2_Installer_Tools___AudioNet_Setup_v4_OLDPEERIPTABLE$_STRING_MAX_LEN );
#define __S2_Installer_Tools___AudioNet_Setup_v4_NEWPEERIPTABLE$_STRING_MAX_LEN 60
CREATE_STRING_STRUCT( S2_Installer_Tools___AudioNet_Setup_v4, __NEWPEERIPTABLE$, __S2_Installer_Tools___AudioNet_Setup_v4_NEWPEERIPTABLE$_STRING_MAX_LEN );
#define __S2_Installer_Tools___AudioNet_Setup_v4_LIST$_ARRAY_NUM_ELEMS 10
#define __S2_Installer_Tools___AudioNet_Setup_v4_LIST$_ARRAY_NUM_CHARS 50
CREATE_STRING_ARRAY( S2_Installer_Tools___AudioNet_Setup_v4, __LIST$, __S2_Installer_Tools___AudioNet_Setup_v4_LIST$_ARRAY_NUM_ELEMS, __S2_Installer_Tools___AudioNet_Setup_v4_LIST$_ARRAY_NUM_CHARS );

/*
* STRUCTURE
*/
#define __S2_Installer_Tools___AudioNet_Setup_v4_MENUSTACK_STRUCT_MAX_LEN 5
CREATE_STRUCTURE_ARRAY( S2_Installer_Tools___AudioNet_Setup_v4, __MENUSTACK, STACK, __S2_Installer_Tools___AudioNet_Setup_v4_MENUSTACK_STRUCT_MAX_LEN );

START_GLOBAL_VAR_STRUCT( S2_Installer_Tools___AudioNet_Setup_v4 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __SOFTKEY );
   DECLARE_IO_ARRAY( __SCROLLLISTHIGHLIGHT );
   DECLARE_IO_ARRAY( __SCROLLLISTINDICATOR );
   DECLARE_IO_ARRAY( __SCROLLLIST$ );
   DECLARE_IO_ARRAY( __SOFTKEY$ );
   DECLARE_IO_ARRAY( __SYSTEMINFOOUT$ );
   unsigned short __SCROLLINDEX;
   unsigned short __SCROLLHIGHLIGHT;
   unsigned short __SCROLLMAX;
   unsigned short __STACKCOUNTER;
   unsigned short __OCTETBEINGSETUP;
   unsigned short __SEMAPHORE;
   unsigned short __OCTET;
   unsigned short __BUSY;
   unsigned short __DHCPORIGINAL;
   unsigned short __DHCPTEMP;
   unsigned short __TEMPPEERIPID;
   unsigned short __ORIGINALPEERIPID;
   DECLARE_INTARRAY( S2_Installer_Tools___AudioNet_Setup_v4, __IPFLAG );
   DECLARE_INTARRAY( S2_Installer_Tools___AudioNet_Setup_v4, __ORIGINALOCTET );
   DECLARE_INTARRAY( S2_Installer_Tools___AudioNet_Setup_v4, __TEMPOCTET );
   DECLARE_INTARRAY( S2_Installer_Tools___AudioNet_Setup_v4, __NEWOCTET );
   long __SLOPE;
   long __INTERCEPT;
   DECLARE_STRING_STRUCT( S2_Installer_Tools___AudioNet_Setup_v4, __HOSTNAMETEMP$ );
   DECLARE_STRING_STRUCT( S2_Installer_Tools___AudioNet_Setup_v4, __OLDPEERIPTABLE$ );
   DECLARE_STRING_STRUCT( S2_Installer_Tools___AudioNet_Setup_v4, __NEWPEERIPTABLE$ );
   DECLARE_STRING_ARRAY( S2_Installer_Tools___AudioNet_Setup_v4, __LIST$ );
   DECLARE_STRING_STRUCT( S2_Installer_Tools___AudioNet_Setup_v4, __ACCELERATEDKNOBTRIG );
   DECLARE_STRING_STRUCT( S2_Installer_Tools___AudioNet_Setup_v4, __MACADDRESSIN$ );
   DECLARE_STRING_STRUCT( S2_Installer_Tools___AudioNet_Setup_v4, __HOSTNAMEIN$ );
   DECLARE_STRING_STRUCT( S2_Installer_Tools___AudioNet_Setup_v4, __EDITEDHOSTNAMEIN$ );
   DECLARE_STRING_ARRAY( S2_Installer_Tools___AudioNet_Setup_v4, __SYSTEMINFO$ );
   DECLARE_STRING_ARRAY( S2_Installer_Tools___AudioNet_Setup_v4, __DNS$ );
   DECLARE_STRUCT_ARRAY( S2_Installer_Tools___AudioNet_Setup_v4, __MENUSTACK );
};

START_NVRAM_VAR_STRUCT( S2_Installer_Tools___AudioNet_Setup_v4 )
{
};

DEFINE_WAITEVENT( S2_Installer_Tools___AudioNet_Setup_v4, __SPLS_TMPVAR__WAITLABEL_0__ );
DEFINE_WAITEVENT( S2_Installer_Tools___AudioNet_Setup_v4, RETRIEVINGWAIT );


#endif //__S2_INSTALLER_TOOLS___AUDIONET_SETUP_V4_H__

