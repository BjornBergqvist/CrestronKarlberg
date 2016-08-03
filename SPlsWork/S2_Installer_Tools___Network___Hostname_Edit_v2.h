#ifndef __S2_INSTALLER_TOOLS___NETWORK___HOSTNAME_EDIT_V2_H__
#define __S2_INSTALLER_TOOLS___NETWORK___HOSTNAME_EDIT_V2_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Installer_Tools___Network___Hostname_Edit_v2_NEXTCHARINSELECTION_DIG_INPUT 0
#define __S2_Installer_Tools___Network___Hostname_Edit_v2_PREVCHARINSELECTION_DIG_INPUT 1
#define __S2_Installer_Tools___Network___Hostname_Edit_v2_NEXTCHARINTEXT_DIG_INPUT 2
#define __S2_Installer_Tools___Network___Hostname_Edit_v2_PREVCHARINTEXT_DIG_INPUT 3
#define __S2_Installer_Tools___Network___Hostname_Edit_v2_BACKSPACE_DIG_INPUT 4
#define __S2_Installer_Tools___Network___Hostname_Edit_v2_DELETECHAR_DIG_INPUT 5
#define __S2_Installer_Tools___Network___Hostname_Edit_v2_DONE_DIG_INPUT 6
#define __S2_Installer_Tools___Network___Hostname_Edit_v2_CANCEL_DIG_INPUT 7
#define __S2_Installer_Tools___Network___Hostname_Edit_v2_CLEAR_DIG_INPUT 8
#define __S2_Installer_Tools___Network___Hostname_Edit_v2_INSERTSPACETORIGHT_DIG_INPUT 9
#define __S2_Installer_Tools___Network___Hostname_Edit_v2_INSERTSPACETOLEFT_DIG_INPUT 10
#define __S2_Installer_Tools___Network___Hostname_Edit_v2_DEBUG_DIG_INPUT 11


/*
* ANALOG_INPUT
*/
#define __S2_Installer_Tools___Network___Hostname_Edit_v2_MAXNEWTEXTLENGTH_ANALOG_INPUT 0
#define __S2_Installer_Tools___Network___Hostname_Edit_v2_MAXCHARACTERSINDISPLAY_ANALOG_INPUT 1

#define __S2_Installer_Tools___Network___Hostname_Edit_v2_SELECTION$_STRING_INPUT 2
#define __S2_Installer_Tools___Network___Hostname_Edit_v2_SELECTION$_STRING_MAX_LEN 100
CREATE_STRING_STRUCT( S2_Installer_Tools___Network___Hostname_Edit_v2, __SELECTION$, __S2_Installer_Tools___Network___Hostname_Edit_v2_SELECTION$_STRING_MAX_LEN );
#define __S2_Installer_Tools___Network___Hostname_Edit_v2_TEXT$_STRING_INPUT 3
#define __S2_Installer_Tools___Network___Hostname_Edit_v2_TEXT$_STRING_MAX_LEN 100
CREATE_STRING_STRUCT( S2_Installer_Tools___Network___Hostname_Edit_v2, __TEXT$, __S2_Installer_Tools___Network___Hostname_Edit_v2_TEXT$_STRING_MAX_LEN );



/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/
#define __S2_Installer_Tools___Network___Hostname_Edit_v2_CURSORPOSITIONOUT_ANALOG_OUTPUT 0

#define __S2_Installer_Tools___Network___Hostname_Edit_v2_TEXTEDIT$_STRING_OUTPUT 1
#define __S2_Installer_Tools___Network___Hostname_Edit_v2_FINALTEXT$_STRING_OUTPUT 2


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
#define __S2_Installer_Tools___Network___Hostname_Edit_v2_TEXTINTERMEDIATE$_STRING_MAX_LEN 100
CREATE_STRING_STRUCT( S2_Installer_Tools___Network___Hostname_Edit_v2, __TEXTINTERMEDIATE$, __S2_Installer_Tools___Network___Hostname_Edit_v2_TEXTINTERMEDIATE$_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Installer_Tools___Network___Hostname_Edit_v2 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   unsigned short __SELECTIONPOSITION;
   unsigned short __IMAXNEWTEXTLENGTH;
   unsigned short __CURSORPOSITION;
   DECLARE_STRING_STRUCT( S2_Installer_Tools___Network___Hostname_Edit_v2, __TEXTINTERMEDIATE$ );
   DECLARE_STRING_STRUCT( S2_Installer_Tools___Network___Hostname_Edit_v2, __SELECTION$ );
   DECLARE_STRING_STRUCT( S2_Installer_Tools___Network___Hostname_Edit_v2, __TEXT$ );
};

START_NVRAM_VAR_STRUCT( S2_Installer_Tools___Network___Hostname_Edit_v2 )
{
};



#endif //__S2_INSTALLER_TOOLS___NETWORK___HOSTNAME_EDIT_V2_H__

