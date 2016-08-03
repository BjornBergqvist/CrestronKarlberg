#ifndef __S2_AES_INSTALLER_TOOLS_SMALL_V1_1_H__
#define __S2_AES_INSTALLER_TOOLS_SMALL_V1_1_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_AES_Installer_Tools_Small_v1_1_KNOBLEFT_DIG_INPUT 0
#define __S2_AES_Installer_Tools_Small_v1_1_KNOBRIGHT_DIG_INPUT 1
#define __S2_AES_Installer_Tools_Small_v1_1_ENTER_DIG_INPUT 2
#define __S2_AES_Installer_Tools_Small_v1_1_MENU_DIG_INPUT 3
#define __S2_AES_Installer_Tools_Small_v1_1_START_DIG_INPUT 4
#define __S2_AES_Installer_Tools_Small_v1_1_WRITECONFIG_DIG_INPUT 5
#define __S2_AES_Installer_Tools_Small_v1_1_AUDIONETCONFIGURATIONCOMPLETE_DIG_INPUT 6


/*
* ANALOG_INPUT
*/
#define __S2_AES_Installer_Tools_Small_v1_1_SCROLLPAGESIZE_ANALOG_INPUT 0
#define __S2_AES_Installer_Tools_Small_v1_1_SLOT1ID_ANALOG_INPUT 1
#define __S2_AES_Installer_Tools_Small_v1_1_SLOT2ID_ANALOG_INPUT 2
#define __S2_AES_Installer_Tools_Small_v1_1_SLOT3ID_ANALOG_INPUT 3
#define __S2_AES_Installer_Tools_Small_v1_1_TOTALAUDIONETCARDS_ANALOG_INPUT 4



#define __S2_AES_Installer_Tools_Small_v1_1_ABOUT$_STRING_INPUT 5
#define __S2_AES_Installer_Tools_Small_v1_1_ABOUT$_ARRAY_NUM_ELEMS 9
#define __S2_AES_Installer_Tools_Small_v1_1_ABOUT$_ARRAY_NUM_CHARS 48
CREATE_STRING_ARRAY( S2_AES_Installer_Tools_Small_v1_1, __ABOUT$, __S2_AES_Installer_Tools_Small_v1_1_ABOUT$_ARRAY_NUM_ELEMS, __S2_AES_Installer_Tools_Small_v1_1_ABOUT$_ARRAY_NUM_CHARS );

/*
* DIGITAL_OUTPUT
*/
#define __S2_AES_Installer_Tools_Small_v1_1_EXITINSTALLER_DIG_OUTPUT 0

#define __S2_AES_Installer_Tools_Small_v1_1_DIGITALOUT_DIG_OUTPUT 1
#define __S2_AES_Installer_Tools_Small_v1_1_DIGITALOUT_ARRAY_LENGTH 8

/*
* ANALOG_OUTPUT
*/
#define __S2_AES_Installer_Tools_Small_v1_1_CURRENTMENU_ANALOG_OUTPUT 0
#define __S2_AES_Installer_Tools_Small_v1_1_BACKLIGHTCONFIGURED_ANALOG_OUTPUT 1
#define __S2_AES_Installer_Tools_Small_v1_1_FRONTPANELLOCKCONFIGURED_ANALOG_OUTPUT 2
#define __S2_AES_Installer_Tools_Small_v1_1_AUDIONETSELECTEDOUT_ANALOG_OUTPUT 3


#define __S2_AES_Installer_Tools_Small_v1_1_ANALOGOUT_ANALOG_OUTPUT 4
#define __S2_AES_Installer_Tools_Small_v1_1_ANALOGOUT_ARRAY_LENGTH 5
#define __S2_AES_Installer_Tools_Small_v1_1_SOFTKEY$_STRING_OUTPUT 9
#define __S2_AES_Installer_Tools_Small_v1_1_SOFTKEY$_ARRAY_LENGTH 4
#define __S2_AES_Installer_Tools_Small_v1_1_SERIALOUT$_STRING_OUTPUT 13
#define __S2_AES_Installer_Tools_Small_v1_1_SERIALOUT$_ARRAY_LENGTH 7

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
#define __S2_AES_Installer_Tools_Small_v1_1_ABOUTINDEX$_ARRAY_NUM_ELEMS 9
#define __S2_AES_Installer_Tools_Small_v1_1_ABOUTINDEX$_ARRAY_NUM_CHARS 10
CREATE_STRING_ARRAY( S2_AES_Installer_Tools_Small_v1_1, __ABOUTINDEX$, __S2_AES_Installer_Tools_Small_v1_1_ABOUTINDEX$_ARRAY_NUM_ELEMS, __S2_AES_Installer_Tools_Small_v1_1_ABOUTINDEX$_ARRAY_NUM_CHARS );
#define __S2_AES_Installer_Tools_Small_v1_1_LIST$_ARRAY_NUM_ELEMS 4
#define __S2_AES_Installer_Tools_Small_v1_1_LIST$_ARRAY_NUM_CHARS 32
CREATE_STRING_ARRAY( S2_AES_Installer_Tools_Small_v1_1, __LIST$, __S2_AES_Installer_Tools_Small_v1_1_LIST$_ARRAY_NUM_ELEMS, __S2_AES_Installer_Tools_Small_v1_1_LIST$_ARRAY_NUM_CHARS );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_AES_Installer_Tools_Small_v1_1 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __DIGITALOUT );
   DECLARE_IO_ARRAY( __ANALOGOUT );
   DECLARE_IO_ARRAY( __SOFTKEY$ );
   DECLARE_IO_ARRAY( __SERIALOUT$ );
   unsigned short __SCROLLINDEX;
   unsigned short __SCROLLHIGHLIGHT;
   unsigned short __SCROLLMAX;
   unsigned short __OLDSCROLLINDEX;
   unsigned short __OLDSCROLLHIGHLIGHT;
   unsigned short __AUDIONETSELECTED;
   unsigned short __CENIPODCONFIGURED;
   unsigned short __AASCONFIGURED;
   unsigned short __CENISERVER_CENIDOCVCONFIGURED;
   DECLARE_STRING_ARRAY( S2_AES_Installer_Tools_Small_v1_1, __ABOUTINDEX$ );
   DECLARE_STRING_ARRAY( S2_AES_Installer_Tools_Small_v1_1, __LIST$ );
   DECLARE_STRING_ARRAY( S2_AES_Installer_Tools_Small_v1_1, __ABOUT$ );
};

START_NVRAM_VAR_STRUCT( S2_AES_Installer_Tools_Small_v1_1 )
{
};



#endif //__S2_AES_INSTALLER_TOOLS_SMALL_V1_1_H__

