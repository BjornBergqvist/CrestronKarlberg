using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_ONKYO_TX_NR5008_FEEDBACK_V1_0
{
    public class UserModuleClass_ONKYO_TX_NR5008_FEEDBACK_V1_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput NET_FF_REW_PUSHED;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> PASSWORD_KEY;
        Crestron.Logos.SplusObjects.BufferInput FROM_DEVICE__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput INPUT_SIRIUS_PASSWORD;
        Crestron.Logos.SplusObjects.DigitalOutput SIRIUS_PASSWORD_WRONG;
        Crestron.Logos.SplusObjects.AnalogOutput SLEEP_TIME;
        Crestron.Logos.SplusObjects.AnalogOutput MAIN_VOLUME_IN;
        Crestron.Logos.SplusObjects.AnalogOutput ZONE_2_VOLUME_IN;
        Crestron.Logos.SplusObjects.AnalogOutput ZONE_3_VOLUME_IN;
        Crestron.Logos.SplusObjects.AnalogOutput ZONE_4_VOLUME_IN;
        Crestron.Logos.SplusObjects.StringOutput SIRIUS_CHANNEL_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SIRIUS_CHANNEL_NUMBER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SIRIUS_TITLE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SIRIUS_ARTIST__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SIRIUS_CATEGORY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TUNER_FREQUENCY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TUNER_ZONE_FREQUENCY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TUNER_ZONE_3_FREQUENCY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TUNER_ZONE_4_FREQUENCY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SIRIUS_PASSWORD__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SIRIUS_PASSWORD_STARS__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_ARTIST__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_CHANNEL_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_TITLE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_RADIO_DETAIL__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput HD_TUNER_STATUS__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NAT_ARTIST__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NAT_ALBUM__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NAT_TITLE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NAT_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NAT_PLAY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NAT_REPEAT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NAT_SHUFFLE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NAT_TRACK__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TO_DEVICE__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> NET_CURSOR_POSITION_LINE;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> NET_LINE_TEXT;
        ushort ITEMP = 0;
        ushort IPASSNEEDED = 0;
        ushort ISLEEP = 0;
        ushort IFLAG1 = 0;
        ushort A = 0;
        ushort IVOL = 0;
        ushort IVOL2 = 0;
        ushort IVOL3 = 0;
        ushort IVOL4 = 0;
        ushort ITEMP1 = 0;
        ushort ICURSORPOSITION = 0;
        ushort ITEMP2 = 0;
        ushort ITEMP3 = 0;
        ushort INETDELAY = 0;
        CrestronString STEMP;
        CrestronString SSIRIUSCHNAME;
        CrestronString SSIRIUSCHNUM;
        CrestronString SSIRIUSTITLE;
        CrestronString SSIRIUSARTIST;
        CrestronString SSIRIUSCAT;
        CrestronString STEMP1;
        CrestronString STUNER;
        CrestronString STUNERZONE;
        CrestronString STUNER3;
        CrestronString SPASSWORD;
        CrestronString SPASSSTARS;
        CrestronString SHDTITLE;
        CrestronString SHDARTIST;
        CrestronString SHDCHNAME;
        CrestronString SHDDETAIL;
        CrestronString STUNER4;
        CrestronString [] SLINETEXT;
        CrestronString SNATARTIST;
        CrestronString SNATALBUM;
        CrestronString SNATTITLE;
        CrestronString SNATTIME;
        CrestronString SNATPLAY;
        CrestronString SNATREPEAT;
        CrestronString SNATSHUFFLE;
        CrestronString SNATTRACK;
        object NET_FF_REW_PUSHED_OnRelease_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 107;
                CreateWait ( "WNETDELAY" , 500 , WNETDELAY_Callback ) ;
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    public void WNETDELAY_CallbackFn( object stateInfo )
    {
    
        try
        {
            Wait __LocalWait__ = (Wait)stateInfo;
            SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
            __LocalWait__.RemoveFromList();
            
            
            __context__.SourceCodeLine = 109;
            INETDELAY = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 110;
            NAT_PLAY__DOLLAR__  .UpdateValue ( SNATPLAY  ) ; 
            
        
        
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        
    }
    
object NET_FF_REW_PUSHED_OnPush_1 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 116;
        CancelWait ( "WNETDELAY" ) ; 
        __context__.SourceCodeLine = 117;
        INETDELAY = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PASSWORD_KEY_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 122;
        ITEMP = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 123;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IPASSNEEDED == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 125;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 11))  ) ) 
                { 
                __context__.SourceCodeLine = 127;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SPASSWORD ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 129;
                    SPASSWORD  .UpdateValue ( Functions.Left ( SPASSWORD ,  (int) ( (Functions.Length( SPASSWORD ) - 1) ) )  ) ; 
                    __context__.SourceCodeLine = 130;
                    SPASSSTARS  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 131;
                    ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                    ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( SPASSWORD ); 
                    int __FN_FORSTEP_VAL__1 = (int)1; 
                    for ( A  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (A  >= __FN_FORSTART_VAL__1) && (A  <= __FN_FOREND_VAL__1) ) : ( (A  <= __FN_FORSTART_VAL__1) && (A  >= __FN_FOREND_VAL__1) ) ; A  += (ushort)__FN_FORSTEP_VAL__1) 
                        { 
                        __context__.SourceCodeLine = 133;
                        SPASSSTARS  .UpdateValue ( SPASSSTARS + "*"  ) ; 
                        __context__.SourceCodeLine = 131;
                        } 
                    
                    __context__.SourceCodeLine = 135;
                    SIRIUS_PASSWORD__DOLLAR__  .UpdateValue ( SPASSWORD  ) ; 
                    __context__.SourceCodeLine = 136;
                    SIRIUS_PASSWORD_STARS__DOLLAR__  .UpdateValue ( SPASSSTARS  ) ; 
                    } 
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 139;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 12))  ) ) 
                    { 
                    __context__.SourceCodeLine = 141;
                    SPASSWORD  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 142;
                    SPASSSTARS  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 143;
                    SIRIUS_PASSWORD__DOLLAR__  .UpdateValue ( SPASSWORD  ) ; 
                    __context__.SourceCodeLine = 144;
                    SIRIUS_PASSWORD_STARS__DOLLAR__  .UpdateValue ( SPASSSTARS  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 146;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 13))  ) ) 
                        { 
                        __context__.SourceCodeLine = 148;
                        MakeString ( TO_DEVICE__DOLLAR__ , "{0}{1}\r", "!1SLK" , SPASSWORD .PadLeft( 2, '0' )) ; 
                        __context__.SourceCodeLine = 149;
                        SPASSWORD  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 150;
                        SIRIUS_PASSWORD__DOLLAR__  .UpdateValue ( SPASSWORD  ) ; 
                        __context__.SourceCodeLine = 151;
                        SIRIUS_PASSWORD_STARS__DOLLAR__  .UpdateValue ( SPASSWORD  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 153;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 10))  ) ) 
                            { 
                            __context__.SourceCodeLine = 155;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SPASSWORD ) < 4 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 157;
                                MakeString ( SPASSWORD , "{0}0", SPASSWORD ) ; 
                                __context__.SourceCodeLine = 158;
                                SPASSSTARS  .UpdateValue ( ""  ) ; 
                                __context__.SourceCodeLine = 159;
                                ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
                                ushort __FN_FOREND_VAL__2 = (ushort)Functions.Length( SPASSWORD ); 
                                int __FN_FORSTEP_VAL__2 = (int)1; 
                                for ( A  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (A  >= __FN_FORSTART_VAL__2) && (A  <= __FN_FOREND_VAL__2) ) : ( (A  <= __FN_FORSTART_VAL__2) && (A  >= __FN_FOREND_VAL__2) ) ; A  += (ushort)__FN_FORSTEP_VAL__2) 
                                    { 
                                    __context__.SourceCodeLine = 161;
                                    SPASSSTARS  .UpdateValue ( SPASSSTARS + "*"  ) ; 
                                    __context__.SourceCodeLine = 159;
                                    } 
                                
                                __context__.SourceCodeLine = 163;
                                SIRIUS_PASSWORD__DOLLAR__  .UpdateValue ( SPASSWORD  ) ; 
                                __context__.SourceCodeLine = 164;
                                SIRIUS_PASSWORD_STARS__DOLLAR__  .UpdateValue ( SPASSSTARS  ) ; 
                                } 
                            
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 167;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( ITEMP > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( ITEMP < 10 ) )) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 169;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SPASSWORD ) < 4 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 171;
                                    MakeString ( SPASSWORD , "{0}{1:d}", SPASSWORD , (short)ITEMP) ; 
                                    __context__.SourceCodeLine = 172;
                                    SPASSSTARS  .UpdateValue ( ""  ) ; 
                                    __context__.SourceCodeLine = 173;
                                    ushort __FN_FORSTART_VAL__3 = (ushort) ( 1 ) ;
                                    ushort __FN_FOREND_VAL__3 = (ushort)Functions.Length( SPASSWORD ); 
                                    int __FN_FORSTEP_VAL__3 = (int)1; 
                                    for ( A  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (A  >= __FN_FORSTART_VAL__3) && (A  <= __FN_FOREND_VAL__3) ) : ( (A  <= __FN_FORSTART_VAL__3) && (A  >= __FN_FOREND_VAL__3) ) ; A  += (ushort)__FN_FORSTEP_VAL__3) 
                                        { 
                                        __context__.SourceCodeLine = 175;
                                        SPASSSTARS  .UpdateValue ( SPASSSTARS + "*"  ) ; 
                                        __context__.SourceCodeLine = 173;
                                        } 
                                    
                                    __context__.SourceCodeLine = 177;
                                    SIRIUS_PASSWORD__DOLLAR__  .UpdateValue ( SPASSWORD  ) ; 
                                    __context__.SourceCodeLine = 178;
                                    SIRIUS_PASSWORD_STARS__DOLLAR__  .UpdateValue ( SPASSSTARS  ) ; 
                                    } 
                                
                                } 
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            __context__.SourceCodeLine = 181;
            ITEMP = (ushort) ( 100 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROM_DEVICE__DOLLAR___OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 187;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IFLAG1 == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 189;
            IFLAG1 = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 190;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u001A" , FROM_DEVICE__DOLLAR__ ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 192;
                STEMP  .UpdateValue ( Functions.Gather ( "\u001A" , FROM_DEVICE__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 193;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1SLP" , STEMP ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 195;
                    ITEMP1 = (ushort) ( Functions.Find( "!1SLP" , STEMP ) ) ; 
                    __context__.SourceCodeLine = 196;
                    STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1SLP" ) + ITEMP1) ) ,  (int) ( 2 ) )  ) ; 
                    __context__.SourceCodeLine = 197;
                    ITEMP = (ushort) ( Functions.HextoI( STEMP1 ) ) ; 
                    __context__.SourceCodeLine = 198;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP != ISLEEP))  ) ) 
                        { 
                        __context__.SourceCodeLine = 200;
                        ISLEEP = (ushort) ( ITEMP ) ; 
                        __context__.SourceCodeLine = 201;
                        SLEEP_TIME  .Value = (ushort) ( ISLEEP ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 203;
                    STEMP1  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 204;
                    STEMP  .UpdateValue ( ""  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 206;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1MVL" , STEMP ) > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 208;
                        ITEMP1 = (ushort) ( Functions.Find( "!1MVL" , STEMP ) ) ; 
                        __context__.SourceCodeLine = 209;
                        STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1MVL" ) + ITEMP1) ) ,  (int) ( 2 ) )  ) ; 
                        __context__.SourceCodeLine = 210;
                        ITEMP = (ushort) ( Functions.HextoI( STEMP1 ) ) ; 
                        __context__.SourceCodeLine = 211;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP != IVOL))  ) ) 
                            { 
                            __context__.SourceCodeLine = 213;
                            IVOL = (ushort) ( ITEMP ) ; 
                            __context__.SourceCodeLine = 214;
                            MAIN_VOLUME_IN  .Value = (ushort) ( IVOL ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 216;
                        STEMP1  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 217;
                        STEMP  .UpdateValue ( ""  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 219;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1ZVL" , STEMP ) > 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 221;
                            ITEMP1 = (ushort) ( Functions.Find( "!1ZVL" , STEMP ) ) ; 
                            __context__.SourceCodeLine = 222;
                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1ZVL" ) + ITEMP1) ) ,  (int) ( 2 ) )  ) ; 
                            __context__.SourceCodeLine = 223;
                            ITEMP = (ushort) ( Functions.HextoI( STEMP1 ) ) ; 
                            __context__.SourceCodeLine = 224;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP != IVOL2))  ) ) 
                                { 
                                __context__.SourceCodeLine = 226;
                                IVOL2 = (ushort) ( ITEMP ) ; 
                                __context__.SourceCodeLine = 227;
                                ZONE_2_VOLUME_IN  .Value = (ushort) ( IVOL2 ) ; 
                                } 
                            
                            __context__.SourceCodeLine = 229;
                            STEMP1  .UpdateValue ( ""  ) ; 
                            __context__.SourceCodeLine = 230;
                            STEMP  .UpdateValue ( ""  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 232;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1VL3" , STEMP ) > 0 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 234;
                                ITEMP1 = (ushort) ( Functions.Find( "!1VL3" , STEMP ) ) ; 
                                __context__.SourceCodeLine = 235;
                                STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1VL3" ) + ITEMP1) ) ,  (int) ( 2 ) )  ) ; 
                                __context__.SourceCodeLine = 236;
                                ITEMP = (ushort) ( Functions.HextoI( STEMP1 ) ) ; 
                                __context__.SourceCodeLine = 237;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP != IVOL3))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 239;
                                    IVOL3 = (ushort) ( ITEMP ) ; 
                                    __context__.SourceCodeLine = 240;
                                    ZONE_3_VOLUME_IN  .Value = (ushort) ( IVOL3 ) ; 
                                    } 
                                
                                __context__.SourceCodeLine = 242;
                                STEMP1  .UpdateValue ( ""  ) ; 
                                __context__.SourceCodeLine = 243;
                                STEMP  .UpdateValue ( ""  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 245;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1VL4" , STEMP ) > 0 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 247;
                                    ITEMP1 = (ushort) ( Functions.Find( "!1VL4" , STEMP ) ) ; 
                                    __context__.SourceCodeLine = 248;
                                    STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1VL4" ) + ITEMP1) ) ,  (int) ( 2 ) )  ) ; 
                                    __context__.SourceCodeLine = 249;
                                    ITEMP = (ushort) ( Functions.HextoI( STEMP1 ) ) ; 
                                    __context__.SourceCodeLine = 250;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP != IVOL4))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 252;
                                        IVOL4 = (ushort) ( ITEMP ) ; 
                                        __context__.SourceCodeLine = 253;
                                        ZONE_4_VOLUME_IN  .Value = (ushort) ( IVOL4 ) ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 255;
                                    STEMP1  .UpdateValue ( ""  ) ; 
                                    __context__.SourceCodeLine = 256;
                                    STEMP  .UpdateValue ( ""  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 258;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1SCN" , STEMP ) > 0 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 260;
                                        ITEMP1 = (ushort) ( Functions.Find( "!1SCN" , STEMP ) ) ; 
                                        __context__.SourceCodeLine = 261;
                                        STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1SCN" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1SCN" )) - ITEMP1) ) )  ) ; 
                                        __context__.SourceCodeLine = 262;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SSIRIUSCHNAME != STEMP1))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 264;
                                            SSIRIUSCHNAME  .UpdateValue ( STEMP1  ) ; 
                                            __context__.SourceCodeLine = 265;
                                            SIRIUS_CHANNEL_NAME__DOLLAR__  .UpdateValue ( SSIRIUSCHNAME  ) ; 
                                            } 
                                        
                                        __context__.SourceCodeLine = 267;
                                        STEMP1  .UpdateValue ( ""  ) ; 
                                        __context__.SourceCodeLine = 268;
                                        STEMP  .UpdateValue ( ""  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 270;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1SCH" , STEMP ) > 0 ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 272;
                                            ITEMP1 = (ushort) ( Functions.Find( "!1SCH" , STEMP ) ) ; 
                                            __context__.SourceCodeLine = 273;
                                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1SCH" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1SCH" )) - ITEMP1) ) )  ) ; 
                                            __context__.SourceCodeLine = 274;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SSIRIUSCHNUM != STEMP1))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 276;
                                                SSIRIUSCHNUM  .UpdateValue ( STEMP1  ) ; 
                                                __context__.SourceCodeLine = 277;
                                                SIRIUS_CHANNEL_NUMBER__DOLLAR__  .UpdateValue ( SSIRIUSCHNUM  ) ; 
                                                } 
                                            
                                            __context__.SourceCodeLine = 279;
                                            STEMP1  .UpdateValue ( ""  ) ; 
                                            __context__.SourceCodeLine = 280;
                                            STEMP  .UpdateValue ( ""  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 282;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1STI" , STEMP ) > 0 ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 284;
                                                ITEMP1 = (ushort) ( Functions.Find( "!1STI" , STEMP ) ) ; 
                                                __context__.SourceCodeLine = 285;
                                                STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1STI" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1STI" )) - ITEMP1) ) )  ) ; 
                                                __context__.SourceCodeLine = 286;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SSIRIUSTITLE != STEMP1))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 288;
                                                    SSIRIUSTITLE  .UpdateValue ( STEMP1  ) ; 
                                                    __context__.SourceCodeLine = 289;
                                                    SIRIUS_TITLE__DOLLAR__  .UpdateValue ( SSIRIUSTITLE  ) ; 
                                                    } 
                                                
                                                __context__.SourceCodeLine = 291;
                                                STEMP1  .UpdateValue ( ""  ) ; 
                                                __context__.SourceCodeLine = 292;
                                                STEMP  .UpdateValue ( ""  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 294;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1SAT" , STEMP ) > 0 ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 296;
                                                    ITEMP1 = (ushort) ( Functions.Find( "!1SAT" , STEMP ) ) ; 
                                                    __context__.SourceCodeLine = 297;
                                                    STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1SAT" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1SAT" )) - ITEMP1) ) )  ) ; 
                                                    __context__.SourceCodeLine = 298;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SSIRIUSARTIST != STEMP1))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 300;
                                                        SSIRIUSARTIST  .UpdateValue ( STEMP1  ) ; 
                                                        __context__.SourceCodeLine = 301;
                                                        SIRIUS_ARTIST__DOLLAR__  .UpdateValue ( SSIRIUSARTIST  ) ; 
                                                        } 
                                                    
                                                    __context__.SourceCodeLine = 303;
                                                    STEMP1  .UpdateValue ( ""  ) ; 
                                                    __context__.SourceCodeLine = 304;
                                                    STEMP  .UpdateValue ( ""  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 306;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1SCT" , STEMP ) > 0 ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 308;
                                                        ITEMP1 = (ushort) ( Functions.Find( "!1SCT" , STEMP ) ) ; 
                                                        __context__.SourceCodeLine = 309;
                                                        STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1SCT" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1SCT" )) - ITEMP1) ) )  ) ; 
                                                        __context__.SourceCodeLine = 310;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SSIRIUSCAT != STEMP1))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 312;
                                                            SSIRIUSCAT  .UpdateValue ( STEMP1  ) ; 
                                                            __context__.SourceCodeLine = 313;
                                                            SIRIUS_CATEGORY__DOLLAR__  .UpdateValue ( SSIRIUSCAT  ) ; 
                                                            } 
                                                        
                                                        __context__.SourceCodeLine = 315;
                                                        STEMP1  .UpdateValue ( ""  ) ; 
                                                        __context__.SourceCodeLine = 316;
                                                        STEMP  .UpdateValue ( ""  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 318;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1SLKINPUT" , STEMP ) > 0 ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 320;
                                                            IPASSNEEDED = (ushort) ( 1 ) ; 
                                                            __context__.SourceCodeLine = 321;
                                                            INPUT_SIRIUS_PASSWORD  .Value = (ushort) ( IPASSNEEDED ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 324;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1SLKWRONG" , STEMP ) > 0 ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 326;
                                                                IPASSNEEDED = (ushort) ( 0 ) ; 
                                                                __context__.SourceCodeLine = 327;
                                                                INPUT_SIRIUS_PASSWORD  .Value = (ushort) ( IPASSNEEDED ) ; 
                                                                __context__.SourceCodeLine = 328;
                                                                Functions.Pulse ( 10, SIRIUS_PASSWORD_WRONG ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 330;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1TUN" , STEMP ) > 0 ))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 332;
                                                                    ITEMP1 = (ushort) ( Functions.Find( "!1TUN" , STEMP ) ) ; 
                                                                    __context__.SourceCodeLine = 333;
                                                                    STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1TUN" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1TUN" )) - ITEMP1) ) )  ) ; 
                                                                    __context__.SourceCodeLine = 334;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STUNER != STEMP1))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 336;
                                                                        STUNER  .UpdateValue ( STEMP1  ) ; 
                                                                        __context__.SourceCodeLine = 337;
                                                                        TUNER_FREQUENCY__DOLLAR__  .UpdateValue ( STUNER  ) ; 
                                                                        } 
                                                                    
                                                                    __context__.SourceCodeLine = 339;
                                                                    STEMP1  .UpdateValue ( ""  ) ; 
                                                                    __context__.SourceCodeLine = 340;
                                                                    STEMP  .UpdateValue ( ""  ) ; 
                                                                    } 
                                                                
                                                                else 
                                                                    {
                                                                    __context__.SourceCodeLine = 342;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1TUZ" , STEMP ) > 0 ))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 344;
                                                                        ITEMP1 = (ushort) ( Functions.Find( "!1TUZ" , STEMP ) ) ; 
                                                                        __context__.SourceCodeLine = 345;
                                                                        STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1TUZ" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1TUZ" )) - ITEMP1) ) )  ) ; 
                                                                        __context__.SourceCodeLine = 346;
                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STUNERZONE != STEMP1))  ) ) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 348;
                                                                            STUNERZONE  .UpdateValue ( STEMP1  ) ; 
                                                                            __context__.SourceCodeLine = 349;
                                                                            TUNER_ZONE_FREQUENCY__DOLLAR__  .UpdateValue ( STUNERZONE  ) ; 
                                                                            } 
                                                                        
                                                                        __context__.SourceCodeLine = 351;
                                                                        STEMP1  .UpdateValue ( ""  ) ; 
                                                                        __context__.SourceCodeLine = 352;
                                                                        STEMP  .UpdateValue ( ""  ) ; 
                                                                        } 
                                                                    
                                                                    else 
                                                                        {
                                                                        __context__.SourceCodeLine = 354;
                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1TU3" , STEMP ) > 0 ))  ) ) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 356;
                                                                            ITEMP1 = (ushort) ( Functions.Find( "!1TU3" , STEMP ) ) ; 
                                                                            __context__.SourceCodeLine = 357;
                                                                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1TU3" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1TU3" )) - ITEMP1) ) )  ) ; 
                                                                            __context__.SourceCodeLine = 358;
                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STUNER3 != STEMP1))  ) ) 
                                                                                { 
                                                                                __context__.SourceCodeLine = 360;
                                                                                STUNER3  .UpdateValue ( STEMP1  ) ; 
                                                                                __context__.SourceCodeLine = 361;
                                                                                TUNER_ZONE_3_FREQUENCY__DOLLAR__  .UpdateValue ( STUNER3  ) ; 
                                                                                } 
                                                                            
                                                                            __context__.SourceCodeLine = 363;
                                                                            STEMP1  .UpdateValue ( ""  ) ; 
                                                                            __context__.SourceCodeLine = 364;
                                                                            STEMP  .UpdateValue ( ""  ) ; 
                                                                            } 
                                                                        
                                                                        else 
                                                                            {
                                                                            __context__.SourceCodeLine = 366;
                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1TU4" , STEMP ) > 0 ))  ) ) 
                                                                                { 
                                                                                __context__.SourceCodeLine = 368;
                                                                                ITEMP1 = (ushort) ( Functions.Find( "!1TU4" , STEMP ) ) ; 
                                                                                __context__.SourceCodeLine = 369;
                                                                                STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1TU4" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1TU4" )) - ITEMP1) ) )  ) ; 
                                                                                __context__.SourceCodeLine = 370;
                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STUNER4 != STEMP1))  ) ) 
                                                                                    { 
                                                                                    __context__.SourceCodeLine = 372;
                                                                                    STUNER4  .UpdateValue ( STEMP1  ) ; 
                                                                                    __context__.SourceCodeLine = 373;
                                                                                    TUNER_ZONE_4_FREQUENCY__DOLLAR__  .UpdateValue ( STUNER4  ) ; 
                                                                                    } 
                                                                                
                                                                                __context__.SourceCodeLine = 375;
                                                                                STEMP1  .UpdateValue ( ""  ) ; 
                                                                                __context__.SourceCodeLine = 376;
                                                                                STEMP  .UpdateValue ( ""  ) ; 
                                                                                } 
                                                                            
                                                                            else 
                                                                                {
                                                                                __context__.SourceCodeLine = 378;
                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1HTI" , STEMP ) > 0 ))  ) ) 
                                                                                    { 
                                                                                    __context__.SourceCodeLine = 380;
                                                                                    ITEMP1 = (ushort) ( Functions.Find( "!1HTI" , STEMP ) ) ; 
                                                                                    __context__.SourceCodeLine = 381;
                                                                                    STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1HTI" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1HTI" )) - ITEMP1) ) )  ) ; 
                                                                                    __context__.SourceCodeLine = 382;
                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SHDTITLE != STEMP1))  ) ) 
                                                                                        { 
                                                                                        __context__.SourceCodeLine = 384;
                                                                                        SHDTITLE  .UpdateValue ( STEMP1  ) ; 
                                                                                        __context__.SourceCodeLine = 385;
                                                                                        HD_TITLE__DOLLAR__  .UpdateValue ( SHDTITLE  ) ; 
                                                                                        } 
                                                                                    
                                                                                    __context__.SourceCodeLine = 387;
                                                                                    STEMP1  .UpdateValue ( ""  ) ; 
                                                                                    __context__.SourceCodeLine = 388;
                                                                                    STEMP  .UpdateValue ( ""  ) ; 
                                                                                    } 
                                                                                
                                                                                else 
                                                                                    {
                                                                                    __context__.SourceCodeLine = 390;
                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1HAT" , STEMP ) > 0 ))  ) ) 
                                                                                        { 
                                                                                        __context__.SourceCodeLine = 392;
                                                                                        ITEMP1 = (ushort) ( Functions.Find( "!1HAT" , STEMP ) ) ; 
                                                                                        __context__.SourceCodeLine = 393;
                                                                                        STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1HAT" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1HAT" )) - ITEMP1) ) )  ) ; 
                                                                                        __context__.SourceCodeLine = 394;
                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SHDARTIST != STEMP1))  ) ) 
                                                                                            { 
                                                                                            __context__.SourceCodeLine = 396;
                                                                                            SHDARTIST  .UpdateValue ( STEMP1  ) ; 
                                                                                            __context__.SourceCodeLine = 397;
                                                                                            HD_ARTIST__DOLLAR__  .UpdateValue ( SHDARTIST  ) ; 
                                                                                            } 
                                                                                        
                                                                                        __context__.SourceCodeLine = 399;
                                                                                        STEMP1  .UpdateValue ( ""  ) ; 
                                                                                        __context__.SourceCodeLine = 400;
                                                                                        STEMP  .UpdateValue ( ""  ) ; 
                                                                                        } 
                                                                                    
                                                                                    else 
                                                                                        {
                                                                                        __context__.SourceCodeLine = 402;
                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1HCN" , STEMP ) > 0 ))  ) ) 
                                                                                            { 
                                                                                            __context__.SourceCodeLine = 404;
                                                                                            ITEMP1 = (ushort) ( Functions.Find( "!1HCN" , STEMP ) ) ; 
                                                                                            __context__.SourceCodeLine = 405;
                                                                                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1HCN" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1HCN" )) - ITEMP1) ) )  ) ; 
                                                                                            __context__.SourceCodeLine = 406;
                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SHDCHNAME != STEMP1))  ) ) 
                                                                                                { 
                                                                                                __context__.SourceCodeLine = 408;
                                                                                                SHDCHNAME  .UpdateValue ( STEMP1  ) ; 
                                                                                                __context__.SourceCodeLine = 409;
                                                                                                HD_CHANNEL_NAME__DOLLAR__  .UpdateValue ( SHDCHNAME  ) ; 
                                                                                                } 
                                                                                            
                                                                                            __context__.SourceCodeLine = 411;
                                                                                            STEMP1  .UpdateValue ( ""  ) ; 
                                                                                            __context__.SourceCodeLine = 412;
                                                                                            STEMP  .UpdateValue ( ""  ) ; 
                                                                                            } 
                                                                                        
                                                                                        else 
                                                                                            {
                                                                                            __context__.SourceCodeLine = 414;
                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1HDS" , STEMP ) > 0 ))  ) ) 
                                                                                                { 
                                                                                                __context__.SourceCodeLine = 416;
                                                                                                ITEMP1 = (ushort) ( Functions.Find( "!1HDS" , STEMP ) ) ; 
                                                                                                __context__.SourceCodeLine = 417;
                                                                                                STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1HDS" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1HDS" )) - ITEMP1) ) )  ) ; 
                                                                                                __context__.SourceCodeLine = 418;
                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SHDDETAIL != STEMP1))  ) ) 
                                                                                                    { 
                                                                                                    __context__.SourceCodeLine = 420;
                                                                                                    SHDDETAIL  .UpdateValue ( STEMP1  ) ; 
                                                                                                    __context__.SourceCodeLine = 421;
                                                                                                    HD_RADIO_DETAIL__DOLLAR__  .UpdateValue ( SHDDETAIL  ) ; 
                                                                                                    } 
                                                                                                
                                                                                                __context__.SourceCodeLine = 423;
                                                                                                STEMP1  .UpdateValue ( ""  ) ; 
                                                                                                __context__.SourceCodeLine = 424;
                                                                                                STEMP  .UpdateValue ( ""  ) ; 
                                                                                                } 
                                                                                            
                                                                                            else 
                                                                                                {
                                                                                                __context__.SourceCodeLine = 426;
                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1HTS" , STEMP ) > 0 ))  ) ) 
                                                                                                    { 
                                                                                                    __context__.SourceCodeLine = 428;
                                                                                                    ITEMP1 = (ushort) ( Functions.Find( "!1HTS" , STEMP ) ) ; 
                                                                                                    __context__.SourceCodeLine = 429;
                                                                                                    STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1HTS" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1HTS" )) - ITEMP1) ) )  ) ; 
                                                                                                    __context__.SourceCodeLine = 430;
                                                                                                    HD_TUNER_STATUS__DOLLAR__  .UpdateValue ( STEMP1  ) ; 
                                                                                                    __context__.SourceCodeLine = 431;
                                                                                                    STEMP1  .UpdateValue ( ""  ) ; 
                                                                                                    __context__.SourceCodeLine = 432;
                                                                                                    STEMP  .UpdateValue ( ""  ) ; 
                                                                                                    } 
                                                                                                
                                                                                                else 
                                                                                                    {
                                                                                                    __context__.SourceCodeLine = 434;
                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1NLSA" , STEMP ) > 0 ))  ) ) 
                                                                                                        { 
                                                                                                        __context__.SourceCodeLine = 436;
                                                                                                        ITEMP1 = (ushort) ( Functions.Find( "!1NLSA" , STEMP ) ) ; 
                                                                                                        __context__.SourceCodeLine = 437;
                                                                                                        ITEMP2 = (ushort) ( (Functions.Atoi( Functions.Mid( STEMP , (int)( (ITEMP1 + 2) ) , (int)( 8 ) ) ) + 1) ) ; 
                                                                                                        __context__.SourceCodeLine = 438;
                                                                                                        ITEMP3 = (ushort) ( Functions.Find( "\u001A" , STEMP ) ) ; 
                                                                                                        __context__.SourceCodeLine = 439;
                                                                                                        STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( 9 ) ,  (int) ( (ITEMP3 - 9) ) )  ) ; 
                                                                                                        __context__.SourceCodeLine = 440;
                                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SLINETEXT[ ITEMP2 ] != STEMP1))  ) ) 
                                                                                                            { 
                                                                                                            __context__.SourceCodeLine = 442;
                                                                                                            SLINETEXT [ ITEMP2 ]  .UpdateValue ( STEMP1  ) ; 
                                                                                                            __context__.SourceCodeLine = 443;
                                                                                                            NET_LINE_TEXT [ ITEMP2]  .UpdateValue ( SLINETEXT [ ITEMP2 ]  ) ; 
                                                                                                            } 
                                                                                                        
                                                                                                        } 
                                                                                                    
                                                                                                    else 
                                                                                                        {
                                                                                                        __context__.SourceCodeLine = 446;
                                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1NLSC" , STEMP ) > 0 ))  ) ) 
                                                                                                            { 
                                                                                                            __context__.SourceCodeLine = 448;
                                                                                                            ITEMP1 = (ushort) ( Functions.Find( "!1NLSC" , STEMP ) ) ; 
                                                                                                            __context__.SourceCodeLine = 449;
                                                                                                            ITEMP2 = (ushort) ( (Functions.Atoi( Functions.Mid( STEMP , (int)( (ITEMP1 + 2) ) , (int)( 8 ) ) ) + 1) ) ; 
                                                                                                            __context__.SourceCodeLine = 450;
                                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( STEMP , (int)( 7 ) , (int)( 1 ) ) == "-"))  ) ) 
                                                                                                                { 
                                                                                                                __context__.SourceCodeLine = 452;
                                                                                                                ITEMP2 = (ushort) ( 0 ) ; 
                                                                                                                } 
                                                                                                            
                                                                                                            __context__.SourceCodeLine = 454;
                                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICURSORPOSITION != ITEMP2))  ) ) 
                                                                                                                { 
                                                                                                                __context__.SourceCodeLine = 456;
                                                                                                                ICURSORPOSITION = (ushort) ( ITEMP2 ) ; 
                                                                                                                __context__.SourceCodeLine = 457;
                                                                                                                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                                                                                                                ushort __FN_FOREND_VAL__1 = (ushort)10; 
                                                                                                                int __FN_FORSTEP_VAL__1 = (int)1; 
                                                                                                                for ( A  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (A  >= __FN_FORSTART_VAL__1) && (A  <= __FN_FOREND_VAL__1) ) : ( (A  <= __FN_FORSTART_VAL__1) && (A  >= __FN_FOREND_VAL__1) ) ; A  += (ushort)__FN_FORSTEP_VAL__1) 
                                                                                                                    { 
                                                                                                                    __context__.SourceCodeLine = 459;
                                                                                                                    NET_CURSOR_POSITION_LINE [ A]  .Value = (ushort) ( 0 ) ; 
                                                                                                                    __context__.SourceCodeLine = 457;
                                                                                                                    } 
                                                                                                                
                                                                                                                __context__.SourceCodeLine = 461;
                                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ICURSORPOSITION > 0 ))  ) ) 
                                                                                                                    { 
                                                                                                                    __context__.SourceCodeLine = 463;
                                                                                                                    NET_CURSOR_POSITION_LINE [ ICURSORPOSITION]  .Value = (ushort) ( 1 ) ; 
                                                                                                                    } 
                                                                                                                
                                                                                                                } 
                                                                                                            
                                                                                                            __context__.SourceCodeLine = 466;
                                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "P" , Functions.Mid( STEMP , (int)( 8 ) , (int)( 1 ) ) ) > 0 ))  ) ) 
                                                                                                                { 
                                                                                                                __context__.SourceCodeLine = 468;
                                                                                                                ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
                                                                                                                ushort __FN_FOREND_VAL__2 = (ushort)10; 
                                                                                                                int __FN_FORSTEP_VAL__2 = (int)1; 
                                                                                                                for ( A  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (A  >= __FN_FORSTART_VAL__2) && (A  <= __FN_FOREND_VAL__2) ) : ( (A  <= __FN_FORSTART_VAL__2) && (A  >= __FN_FOREND_VAL__2) ) ; A  += (ushort)__FN_FORSTEP_VAL__2) 
                                                                                                                    { 
                                                                                                                    __context__.SourceCodeLine = 470;
                                                                                                                    SLINETEXT [ A ]  .UpdateValue ( ""  ) ; 
                                                                                                                    __context__.SourceCodeLine = 471;
                                                                                                                    NET_LINE_TEXT [ A]  .UpdateValue ( SLINETEXT [ A ]  ) ; 
                                                                                                                    __context__.SourceCodeLine = 468;
                                                                                                                    } 
                                                                                                                
                                                                                                                } 
                                                                                                            
                                                                                                            } 
                                                                                                        
                                                                                                        else 
                                                                                                            {
                                                                                                            __context__.SourceCodeLine = 475;
                                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1NAT" , STEMP ) > 0 ))  ) ) 
                                                                                                                { 
                                                                                                                __context__.SourceCodeLine = 477;
                                                                                                                ITEMP1 = (ushort) ( Functions.Find( "!1NAT" , STEMP ) ) ; 
                                                                                                                __context__.SourceCodeLine = 478;
                                                                                                                STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1NAT" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1NAT" )) - ITEMP1) ) )  ) ; 
                                                                                                                __context__.SourceCodeLine = 479;
                                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNATARTIST != STEMP1))  ) ) 
                                                                                                                    { 
                                                                                                                    __context__.SourceCodeLine = 481;
                                                                                                                    SNATARTIST  .UpdateValue ( STEMP1  ) ; 
                                                                                                                    __context__.SourceCodeLine = 482;
                                                                                                                    NAT_ARTIST__DOLLAR__  .UpdateValue ( SNATARTIST  ) ; 
                                                                                                                    } 
                                                                                                                
                                                                                                                __context__.SourceCodeLine = 484;
                                                                                                                STEMP1  .UpdateValue ( ""  ) ; 
                                                                                                                __context__.SourceCodeLine = 485;
                                                                                                                STEMP  .UpdateValue ( ""  ) ; 
                                                                                                                } 
                                                                                                            
                                                                                                            else 
                                                                                                                {
                                                                                                                __context__.SourceCodeLine = 487;
                                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1NAL" , STEMP ) > 0 ))  ) ) 
                                                                                                                    { 
                                                                                                                    __context__.SourceCodeLine = 489;
                                                                                                                    ITEMP1 = (ushort) ( Functions.Find( "!1NAL" , STEMP ) ) ; 
                                                                                                                    __context__.SourceCodeLine = 490;
                                                                                                                    STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1NAL" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1NAL" )) - ITEMP1) ) )  ) ; 
                                                                                                                    __context__.SourceCodeLine = 491;
                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNATALBUM != STEMP1))  ) ) 
                                                                                                                        { 
                                                                                                                        __context__.SourceCodeLine = 493;
                                                                                                                        SNATALBUM  .UpdateValue ( STEMP1  ) ; 
                                                                                                                        __context__.SourceCodeLine = 494;
                                                                                                                        NAT_ALBUM__DOLLAR__  .UpdateValue ( SNATALBUM  ) ; 
                                                                                                                        } 
                                                                                                                    
                                                                                                                    __context__.SourceCodeLine = 496;
                                                                                                                    STEMP1  .UpdateValue ( ""  ) ; 
                                                                                                                    __context__.SourceCodeLine = 497;
                                                                                                                    STEMP  .UpdateValue ( ""  ) ; 
                                                                                                                    } 
                                                                                                                
                                                                                                                else 
                                                                                                                    {
                                                                                                                    __context__.SourceCodeLine = 499;
                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1NTI" , STEMP ) > 0 ))  ) ) 
                                                                                                                        { 
                                                                                                                        __context__.SourceCodeLine = 501;
                                                                                                                        ITEMP1 = (ushort) ( Functions.Find( "!1NTI" , STEMP ) ) ; 
                                                                                                                        __context__.SourceCodeLine = 502;
                                                                                                                        STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1NTI" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1NTI" )) - ITEMP1) ) )  ) ; 
                                                                                                                        __context__.SourceCodeLine = 503;
                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNATTITLE != STEMP1))  ) ) 
                                                                                                                            { 
                                                                                                                            __context__.SourceCodeLine = 505;
                                                                                                                            SNATTITLE  .UpdateValue ( STEMP1  ) ; 
                                                                                                                            __context__.SourceCodeLine = 506;
                                                                                                                            NAT_TITLE__DOLLAR__  .UpdateValue ( SNATTITLE  ) ; 
                                                                                                                            } 
                                                                                                                        
                                                                                                                        __context__.SourceCodeLine = 508;
                                                                                                                        STEMP1  .UpdateValue ( ""  ) ; 
                                                                                                                        __context__.SourceCodeLine = 509;
                                                                                                                        STEMP  .UpdateValue ( ""  ) ; 
                                                                                                                        } 
                                                                                                                    
                                                                                                                    else 
                                                                                                                        {
                                                                                                                        __context__.SourceCodeLine = 511;
                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1NTM" , STEMP ) > 0 ))  ) ) 
                                                                                                                            { 
                                                                                                                            __context__.SourceCodeLine = 513;
                                                                                                                            ITEMP1 = (ushort) ( Functions.Find( "!1NTM" , STEMP ) ) ; 
                                                                                                                            __context__.SourceCodeLine = 514;
                                                                                                                            STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1NTM" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1NTM" )) - ITEMP1) ) )  ) ; 
                                                                                                                            __context__.SourceCodeLine = 515;
                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNATTIME != STEMP1))  ) ) 
                                                                                                                                { 
                                                                                                                                __context__.SourceCodeLine = 517;
                                                                                                                                SNATTIME  .UpdateValue ( STEMP1  ) ; 
                                                                                                                                __context__.SourceCodeLine = 518;
                                                                                                                                NAT_TIME__DOLLAR__  .UpdateValue ( SNATTIME  ) ; 
                                                                                                                                } 
                                                                                                                            
                                                                                                                            __context__.SourceCodeLine = 520;
                                                                                                                            STEMP1  .UpdateValue ( ""  ) ; 
                                                                                                                            __context__.SourceCodeLine = 521;
                                                                                                                            STEMP  .UpdateValue ( ""  ) ; 
                                                                                                                            } 
                                                                                                                        
                                                                                                                        else 
                                                                                                                            {
                                                                                                                            __context__.SourceCodeLine = 523;
                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1NTR" , STEMP ) > 0 ))  ) ) 
                                                                                                                                { 
                                                                                                                                __context__.SourceCodeLine = 525;
                                                                                                                                ITEMP1 = (ushort) ( Functions.Find( "!1NTR" , STEMP ) ) ; 
                                                                                                                                __context__.SourceCodeLine = 526;
                                                                                                                                STEMP1  .UpdateValue ( Functions.Mid ( STEMP ,  (int) ( (Functions.Length( "!1NTR" ) + ITEMP1) ) ,  (int) ( ((Functions.Length( STEMP ) - Functions.Length( "!1NTR" )) - ITEMP1) ) )  ) ; 
                                                                                                                                __context__.SourceCodeLine = 527;
                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNATTRACK != STEMP1))  ) ) 
                                                                                                                                    { 
                                                                                                                                    __context__.SourceCodeLine = 529;
                                                                                                                                    SNATTRACK  .UpdateValue ( STEMP1  ) ; 
                                                                                                                                    __context__.SourceCodeLine = 530;
                                                                                                                                    NAT_TRACK__DOLLAR__  .UpdateValue ( SNATTRACK  ) ; 
                                                                                                                                    } 
                                                                                                                                
                                                                                                                                __context__.SourceCodeLine = 532;
                                                                                                                                STEMP1  .UpdateValue ( ""  ) ; 
                                                                                                                                __context__.SourceCodeLine = 533;
                                                                                                                                STEMP  .UpdateValue ( ""  ) ; 
                                                                                                                                } 
                                                                                                                            
                                                                                                                            else 
                                                                                                                                {
                                                                                                                                __context__.SourceCodeLine = 535;
                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "!1NST" , STEMP ) > 0 ))  ) ) 
                                                                                                                                    { 
                                                                                                                                    __context__.SourceCodeLine = 537;
                                                                                                                                    ITEMP1 = (ushort) ( Functions.Find( "!1NAT" , STEMP ) ) ; 
                                                                                                                                    __context__.SourceCodeLine = 538;
                                                                                                                                    STEMP1  .UpdateValue ( Functions.Chr (  (int) ( Byte( STEMP , (int)( 6 ) ) ) )  ) ; 
                                                                                                                                    __context__.SourceCodeLine = 539;
                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNATPLAY != STEMP1))  ) ) 
                                                                                                                                        { 
                                                                                                                                        __context__.SourceCodeLine = 541;
                                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (STEMP1 == "P") ) && Functions.TestForTrue ( Functions.BoolToInt (INETDELAY != 1) )) ))  ) ) 
                                                                                                                                            { 
                                                                                                                                            __context__.SourceCodeLine = 543;
                                                                                                                                            SNATPLAY  .UpdateValue ( STEMP1  ) ; 
                                                                                                                                            __context__.SourceCodeLine = 544;
                                                                                                                                            NAT_PLAY__DOLLAR__  .UpdateValue ( SNATPLAY  ) ; 
                                                                                                                                            } 
                                                                                                                                        
                                                                                                                                        else 
                                                                                                                                            {
                                                                                                                                            __context__.SourceCodeLine = 546;
                                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (STEMP1 == "P") ) && Functions.TestForTrue ( Functions.BoolToInt (INETDELAY == 1) )) ))  ) ) 
                                                                                                                                                { 
                                                                                                                                                __context__.SourceCodeLine = 548;
                                                                                                                                                SNATPLAY  .UpdateValue ( STEMP1  ) ; 
                                                                                                                                                } 
                                                                                                                                            
                                                                                                                                            else 
                                                                                                                                                { 
                                                                                                                                                __context__.SourceCodeLine = 552;
                                                                                                                                                SNATPLAY  .UpdateValue ( STEMP1  ) ; 
                                                                                                                                                __context__.SourceCodeLine = 553;
                                                                                                                                                NAT_PLAY__DOLLAR__  .UpdateValue ( SNATPLAY  ) ; 
                                                                                                                                                } 
                                                                                                                                            
                                                                                                                                            }
                                                                                                                                        
                                                                                                                                        } 
                                                                                                                                    
                                                                                                                                    __context__.SourceCodeLine = 556;
                                                                                                                                    STEMP1  .UpdateValue ( Functions.Chr (  (int) ( Byte( STEMP , (int)( 7 ) ) ) )  ) ; 
                                                                                                                                    __context__.SourceCodeLine = 557;
                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNATREPEAT != STEMP1))  ) ) 
                                                                                                                                        { 
                                                                                                                                        __context__.SourceCodeLine = 559;
                                                                                                                                        SNATREPEAT  .UpdateValue ( STEMP1  ) ; 
                                                                                                                                        __context__.SourceCodeLine = 560;
                                                                                                                                        NAT_REPEAT__DOLLAR__  .UpdateValue ( SNATREPEAT  ) ; 
                                                                                                                                        } 
                                                                                                                                    
                                                                                                                                    __context__.SourceCodeLine = 562;
                                                                                                                                    STEMP1  .UpdateValue ( Functions.Chr (  (int) ( Byte( STEMP , (int)( 8 ) ) ) )  ) ; 
                                                                                                                                    __context__.SourceCodeLine = 563;
                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SNATSHUFFLE != STEMP1))  ) ) 
                                                                                                                                        { 
                                                                                                                                        __context__.SourceCodeLine = 565;
                                                                                                                                        SNATSHUFFLE  .UpdateValue ( STEMP1  ) ; 
                                                                                                                                        __context__.SourceCodeLine = 566;
                                                                                                                                        NAT_SHUFFLE__DOLLAR__  .UpdateValue ( SNATSHUFFLE  ) ; 
                                                                                                                                        } 
                                                                                                                                    
                                                                                                                                    __context__.SourceCodeLine = 568;
                                                                                                                                    STEMP1  .UpdateValue ( ""  ) ; 
                                                                                                                                    __context__.SourceCodeLine = 569;
                                                                                                                                    STEMP  .UpdateValue ( ""  ) ; 
                                                                                                                                    } 
                                                                                                                                
                                                                                                                                }
                                                                                                                            
                                                                                                                            }
                                                                                                                        
                                                                                                                        }
                                                                                                                    
                                                                                                                    }
                                                                                                                
                                                                                                                }
                                                                                                            
                                                                                                            }
                                                                                                        
                                                                                                        }
                                                                                                    
                                                                                                    }
                                                                                                
                                                                                                }
                                                                                            
                                                                                            }
                                                                                        
                                                                                        }
                                                                                    
                                                                                    }
                                                                                
                                                                                }
                                                                            
                                                                            }
                                                                        
                                                                        }
                                                                    
                                                                    }
                                                                
                                                                }
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                __context__.SourceCodeLine = 190;
                } 
            
            __context__.SourceCodeLine = 572;
            IFLAG1 = (ushort) ( 0 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 582;
        IFLAG1 = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 583;
        STEMP  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 584;
        STEMP1  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 585;
        ITEMP = (ushort) ( 100 ) ; 
        __context__.SourceCodeLine = 586;
        INETDELAY = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    SocketInfo __socketinfo__ = new SocketInfo( 1, this );
    InitialParametersClass.ResolveHostName = __socketinfo__.ResolveHostName;
    _SplusNVRAM = new SplusNVRAM( this );
    STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    SSIRIUSCHNAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    SSIRIUSCHNUM  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    SSIRIUSTITLE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    SSIRIUSARTIST  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    SSIRIUSCAT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    STEMP1  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    STUNER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 24, this );
    STUNERZONE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 24, this );
    STUNER3  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 24, this );
    SPASSWORD  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
    SPASSSTARS  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
    SHDTITLE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    SHDARTIST  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    SHDCHNAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    SHDDETAIL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    STUNER4  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 24, this );
    SNATARTIST  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
    SNATALBUM  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
    SNATTITLE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
    SNATTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
    SNATPLAY  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
    SNATREPEAT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
    SNATSHUFFLE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
    SNATTRACK  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
    SLINETEXT  = new CrestronString[ 11 ];
    for( uint i = 0; i < 11; i++ )
        SLINETEXT [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 64, this );
    
    NET_FF_REW_PUSHED = new Crestron.Logos.SplusObjects.DigitalInput( NET_FF_REW_PUSHED__DigitalInput__, this );
    m_DigitalInputList.Add( NET_FF_REW_PUSHED__DigitalInput__, NET_FF_REW_PUSHED );
    
    PASSWORD_KEY = new InOutArray<DigitalInput>( 13, this );
    for( uint i = 0; i < 13; i++ )
    {
        PASSWORD_KEY[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( PASSWORD_KEY__DigitalInput__ + i, PASSWORD_KEY__DigitalInput__, this );
        m_DigitalInputList.Add( PASSWORD_KEY__DigitalInput__ + i, PASSWORD_KEY[i+1] );
    }
    
    INPUT_SIRIUS_PASSWORD = new Crestron.Logos.SplusObjects.DigitalOutput( INPUT_SIRIUS_PASSWORD__DigitalOutput__, this );
    m_DigitalOutputList.Add( INPUT_SIRIUS_PASSWORD__DigitalOutput__, INPUT_SIRIUS_PASSWORD );
    
    SIRIUS_PASSWORD_WRONG = new Crestron.Logos.SplusObjects.DigitalOutput( SIRIUS_PASSWORD_WRONG__DigitalOutput__, this );
    m_DigitalOutputList.Add( SIRIUS_PASSWORD_WRONG__DigitalOutput__, SIRIUS_PASSWORD_WRONG );
    
    NET_CURSOR_POSITION_LINE = new InOutArray<DigitalOutput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        NET_CURSOR_POSITION_LINE[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( NET_CURSOR_POSITION_LINE__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( NET_CURSOR_POSITION_LINE__DigitalOutput__ + i, NET_CURSOR_POSITION_LINE[i+1] );
    }
    
    SLEEP_TIME = new Crestron.Logos.SplusObjects.AnalogOutput( SLEEP_TIME__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SLEEP_TIME__AnalogSerialOutput__, SLEEP_TIME );
    
    MAIN_VOLUME_IN = new Crestron.Logos.SplusObjects.AnalogOutput( MAIN_VOLUME_IN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( MAIN_VOLUME_IN__AnalogSerialOutput__, MAIN_VOLUME_IN );
    
    ZONE_2_VOLUME_IN = new Crestron.Logos.SplusObjects.AnalogOutput( ZONE_2_VOLUME_IN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ZONE_2_VOLUME_IN__AnalogSerialOutput__, ZONE_2_VOLUME_IN );
    
    ZONE_3_VOLUME_IN = new Crestron.Logos.SplusObjects.AnalogOutput( ZONE_3_VOLUME_IN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ZONE_3_VOLUME_IN__AnalogSerialOutput__, ZONE_3_VOLUME_IN );
    
    ZONE_4_VOLUME_IN = new Crestron.Logos.SplusObjects.AnalogOutput( ZONE_4_VOLUME_IN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ZONE_4_VOLUME_IN__AnalogSerialOutput__, ZONE_4_VOLUME_IN );
    
    SIRIUS_CHANNEL_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SIRIUS_CHANNEL_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUS_CHANNEL_NAME__DOLLAR____AnalogSerialOutput__, SIRIUS_CHANNEL_NAME__DOLLAR__ );
    
    SIRIUS_CHANNEL_NUMBER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SIRIUS_CHANNEL_NUMBER__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUS_CHANNEL_NUMBER__DOLLAR____AnalogSerialOutput__, SIRIUS_CHANNEL_NUMBER__DOLLAR__ );
    
    SIRIUS_TITLE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SIRIUS_TITLE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUS_TITLE__DOLLAR____AnalogSerialOutput__, SIRIUS_TITLE__DOLLAR__ );
    
    SIRIUS_ARTIST__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SIRIUS_ARTIST__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUS_ARTIST__DOLLAR____AnalogSerialOutput__, SIRIUS_ARTIST__DOLLAR__ );
    
    SIRIUS_CATEGORY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SIRIUS_CATEGORY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUS_CATEGORY__DOLLAR____AnalogSerialOutput__, SIRIUS_CATEGORY__DOLLAR__ );
    
    TUNER_FREQUENCY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__, TUNER_FREQUENCY__DOLLAR__ );
    
    TUNER_ZONE_FREQUENCY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TUNER_ZONE_FREQUENCY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TUNER_ZONE_FREQUENCY__DOLLAR____AnalogSerialOutput__, TUNER_ZONE_FREQUENCY__DOLLAR__ );
    
    TUNER_ZONE_3_FREQUENCY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TUNER_ZONE_3_FREQUENCY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TUNER_ZONE_3_FREQUENCY__DOLLAR____AnalogSerialOutput__, TUNER_ZONE_3_FREQUENCY__DOLLAR__ );
    
    TUNER_ZONE_4_FREQUENCY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TUNER_ZONE_4_FREQUENCY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TUNER_ZONE_4_FREQUENCY__DOLLAR____AnalogSerialOutput__, TUNER_ZONE_4_FREQUENCY__DOLLAR__ );
    
    SIRIUS_PASSWORD__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SIRIUS_PASSWORD__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUS_PASSWORD__DOLLAR____AnalogSerialOutput__, SIRIUS_PASSWORD__DOLLAR__ );
    
    SIRIUS_PASSWORD_STARS__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SIRIUS_PASSWORD_STARS__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUS_PASSWORD_STARS__DOLLAR____AnalogSerialOutput__, SIRIUS_PASSWORD_STARS__DOLLAR__ );
    
    HD_ARTIST__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_ARTIST__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_ARTIST__DOLLAR____AnalogSerialOutput__, HD_ARTIST__DOLLAR__ );
    
    HD_CHANNEL_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_CHANNEL_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_CHANNEL_NAME__DOLLAR____AnalogSerialOutput__, HD_CHANNEL_NAME__DOLLAR__ );
    
    HD_TITLE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_TITLE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_TITLE__DOLLAR____AnalogSerialOutput__, HD_TITLE__DOLLAR__ );
    
    HD_RADIO_DETAIL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_RADIO_DETAIL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_RADIO_DETAIL__DOLLAR____AnalogSerialOutput__, HD_RADIO_DETAIL__DOLLAR__ );
    
    HD_TUNER_STATUS__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( HD_TUNER_STATUS__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_TUNER_STATUS__DOLLAR____AnalogSerialOutput__, HD_TUNER_STATUS__DOLLAR__ );
    
    NAT_ARTIST__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NAT_ARTIST__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAT_ARTIST__DOLLAR____AnalogSerialOutput__, NAT_ARTIST__DOLLAR__ );
    
    NAT_ALBUM__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NAT_ALBUM__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAT_ALBUM__DOLLAR____AnalogSerialOutput__, NAT_ALBUM__DOLLAR__ );
    
    NAT_TITLE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NAT_TITLE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAT_TITLE__DOLLAR____AnalogSerialOutput__, NAT_TITLE__DOLLAR__ );
    
    NAT_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NAT_TIME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAT_TIME__DOLLAR____AnalogSerialOutput__, NAT_TIME__DOLLAR__ );
    
    NAT_PLAY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NAT_PLAY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAT_PLAY__DOLLAR____AnalogSerialOutput__, NAT_PLAY__DOLLAR__ );
    
    NAT_REPEAT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NAT_REPEAT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAT_REPEAT__DOLLAR____AnalogSerialOutput__, NAT_REPEAT__DOLLAR__ );
    
    NAT_SHUFFLE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NAT_SHUFFLE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAT_SHUFFLE__DOLLAR____AnalogSerialOutput__, NAT_SHUFFLE__DOLLAR__ );
    
    NAT_TRACK__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NAT_TRACK__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAT_TRACK__DOLLAR____AnalogSerialOutput__, NAT_TRACK__DOLLAR__ );
    
    TO_DEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_DEVICE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_DEVICE__DOLLAR____AnalogSerialOutput__, TO_DEVICE__DOLLAR__ );
    
    NET_LINE_TEXT = new InOutArray<StringOutput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        NET_LINE_TEXT[i+1] = new Crestron.Logos.SplusObjects.StringOutput( NET_LINE_TEXT__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( NET_LINE_TEXT__AnalogSerialOutput__ + i, NET_LINE_TEXT[i+1] );
    }
    
    FROM_DEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROM_DEVICE__DOLLAR____AnalogSerialInput__, 200, this );
    m_StringInputList.Add( FROM_DEVICE__DOLLAR____AnalogSerialInput__, FROM_DEVICE__DOLLAR__ );
    
    WNETDELAY_Callback = new WaitFunction( WNETDELAY_CallbackFn );
    
    NET_FF_REW_PUSHED.OnDigitalRelease.Add( new InputChangeHandlerWrapper( NET_FF_REW_PUSHED_OnRelease_0, false ) );
    NET_FF_REW_PUSHED.OnDigitalPush.Add( new InputChangeHandlerWrapper( NET_FF_REW_PUSHED_OnPush_1, false ) );
    for( uint i = 0; i < 13; i++ )
        PASSWORD_KEY[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( PASSWORD_KEY_OnPush_2, false ) );
        
    FROM_DEVICE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_DEVICE__DOLLAR___OnChange_3, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_ONKYO_TX_NR5008_FEEDBACK_V1_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction WNETDELAY_Callback;


const uint NET_FF_REW_PUSHED__DigitalInput__ = 0;
const uint PASSWORD_KEY__DigitalInput__ = 1;
const uint FROM_DEVICE__DOLLAR____AnalogSerialInput__ = 0;
const uint INPUT_SIRIUS_PASSWORD__DigitalOutput__ = 0;
const uint SIRIUS_PASSWORD_WRONG__DigitalOutput__ = 1;
const uint SLEEP_TIME__AnalogSerialOutput__ = 0;
const uint MAIN_VOLUME_IN__AnalogSerialOutput__ = 1;
const uint ZONE_2_VOLUME_IN__AnalogSerialOutput__ = 2;
const uint ZONE_3_VOLUME_IN__AnalogSerialOutput__ = 3;
const uint ZONE_4_VOLUME_IN__AnalogSerialOutput__ = 4;
const uint SIRIUS_CHANNEL_NAME__DOLLAR____AnalogSerialOutput__ = 5;
const uint SIRIUS_CHANNEL_NUMBER__DOLLAR____AnalogSerialOutput__ = 6;
const uint SIRIUS_TITLE__DOLLAR____AnalogSerialOutput__ = 7;
const uint SIRIUS_ARTIST__DOLLAR____AnalogSerialOutput__ = 8;
const uint SIRIUS_CATEGORY__DOLLAR____AnalogSerialOutput__ = 9;
const uint TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__ = 10;
const uint TUNER_ZONE_FREQUENCY__DOLLAR____AnalogSerialOutput__ = 11;
const uint TUNER_ZONE_3_FREQUENCY__DOLLAR____AnalogSerialOutput__ = 12;
const uint TUNER_ZONE_4_FREQUENCY__DOLLAR____AnalogSerialOutput__ = 13;
const uint SIRIUS_PASSWORD__DOLLAR____AnalogSerialOutput__ = 14;
const uint SIRIUS_PASSWORD_STARS__DOLLAR____AnalogSerialOutput__ = 15;
const uint HD_ARTIST__DOLLAR____AnalogSerialOutput__ = 16;
const uint HD_CHANNEL_NAME__DOLLAR____AnalogSerialOutput__ = 17;
const uint HD_TITLE__DOLLAR____AnalogSerialOutput__ = 18;
const uint HD_RADIO_DETAIL__DOLLAR____AnalogSerialOutput__ = 19;
const uint HD_TUNER_STATUS__DOLLAR____AnalogSerialOutput__ = 20;
const uint NAT_ARTIST__DOLLAR____AnalogSerialOutput__ = 21;
const uint NAT_ALBUM__DOLLAR____AnalogSerialOutput__ = 22;
const uint NAT_TITLE__DOLLAR____AnalogSerialOutput__ = 23;
const uint NAT_TIME__DOLLAR____AnalogSerialOutput__ = 24;
const uint NAT_PLAY__DOLLAR____AnalogSerialOutput__ = 25;
const uint NAT_REPEAT__DOLLAR____AnalogSerialOutput__ = 26;
const uint NAT_SHUFFLE__DOLLAR____AnalogSerialOutput__ = 27;
const uint NAT_TRACK__DOLLAR____AnalogSerialOutput__ = 28;
const uint TO_DEVICE__DOLLAR____AnalogSerialOutput__ = 29;
const uint NET_CURSOR_POSITION_LINE__DigitalOutput__ = 2;
const uint NET_LINE_TEXT__AnalogSerialOutput__ = 30;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
