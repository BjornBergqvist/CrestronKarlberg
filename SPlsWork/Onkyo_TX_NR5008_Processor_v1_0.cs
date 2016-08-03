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

namespace UserModule_ONKYO_TX_NR5008_PROCESSOR_V1_0
{
    public class UserModuleClass_ONKYO_TX_NR5008_PROCESSOR_V1_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput VOLUME_UP;
        Crestron.Logos.SplusObjects.DigitalInput VOLUME_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput VOLUME_DONE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> TUNER_KEY;
        Crestron.Logos.SplusObjects.AnalogInput VOLUME_IN;
        Crestron.Logos.SplusObjects.AnalogInput SELECTED_TUNER;
        Crestron.Logos.SplusObjects.BufferInput TUNER_COMMAND__DOLLAR__;
        Crestron.Logos.SplusObjects.BufferInput VOLUME_COMMAND__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput VOLUME_FB;
        Crestron.Logos.SplusObjects.StringOutput TUNER_FREQUENCY__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TO_DEVICE__DOLLAR__;
        ushort IVOL = 0;
        ushort IVOLCHANGING = 0;
        CrestronString SFREQ;
        CrestronString STUNER;
        CrestronString SVOLUME;
        object TUNER_KEY_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort ITEMP = 0;
                
                
                __context__.SourceCodeLine = 69;
                ITEMP = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                __context__.SourceCodeLine = 70;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP != 100))  ) ) 
                    { 
                    __context__.SourceCodeLine = 72;
                    switch ((int)SELECTED_TUNER  .UshortValue)
                    
                        { 
                        case 4 : 
                        
                            { 
                            __context__.SourceCodeLine = 76;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITEMP >= 10 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 78;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 10))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 80;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SFREQ ) < 3 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 82;
                                        MakeString ( SFREQ , "{0}0", SFREQ ) ; 
                                        __context__.SourceCodeLine = 83;
                                        TUNER_FREQUENCY__DOLLAR__  .UpdateValue ( SFREQ  ) ; 
                                        __context__.SourceCodeLine = 84;
                                        ITEMP = (ushort) ( 100 ) ; 
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 88;
                                        ITEMP = (ushort) ( 100 ) ; 
                                        } 
                                    
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 91;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 11))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 93;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SFREQ ) > 0 ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 95;
                                            SFREQ  .UpdateValue ( Functions.Left ( SFREQ ,  (int) ( (Functions.Length( SFREQ ) - 1) ) )  ) ; 
                                            __context__.SourceCodeLine = 96;
                                            TUNER_FREQUENCY__DOLLAR__  .UpdateValue ( SFREQ  ) ; 
                                            __context__.SourceCodeLine = 97;
                                            ITEMP = (ushort) ( 100 ) ; 
                                            } 
                                        
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 100;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 12))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 102;
                                            SFREQ  .UpdateValue ( ""  ) ; 
                                            __context__.SourceCodeLine = 103;
                                            TUNER_FREQUENCY__DOLLAR__  .UpdateValue ( SFREQ  ) ; 
                                            __context__.SourceCodeLine = 104;
                                            ITEMP = (ushort) ( 100 ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 106;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 13))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 108;
                                                MakeString ( TO_DEVICE__DOLLAR__ , "{0}{1}\r", "!1SCH" , SFREQ .PadLeft( 3, '0' )) ; 
                                                __context__.SourceCodeLine = 109;
                                                SFREQ  .UpdateValue ( ""  ) ; 
                                                __context__.SourceCodeLine = 110;
                                                ITEMP = (ushort) ( 100 ) ; 
                                                } 
                                            
                                            else 
                                                { 
                                                __context__.SourceCodeLine = 114;
                                                ITEMP = (ushort) ( 100 ) ; 
                                                } 
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 119;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SFREQ ) < 3 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 121;
                                    MakeString ( SFREQ , "{0}{1:d}", SFREQ , (short)ITEMP) ; 
                                    __context__.SourceCodeLine = 122;
                                    TUNER_FREQUENCY__DOLLAR__  .UpdateValue ( SFREQ  ) ; 
                                    __context__.SourceCodeLine = 123;
                                    ITEMP = (ushort) ( 100 ) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 127;
                                    ITEMP = (ushort) ( 100 ) ; 
                                    } 
                                
                                } 
                            
                            __context__.SourceCodeLine = 130;
                            break ; 
                            } 
                        
                        goto case 1 ;
                        case 1 : 
                        
                            { 
                            __context__.SourceCodeLine = 134;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITEMP >= 10 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 136;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 10))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 138;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SFREQ ) < 5 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 140;
                                        MakeString ( SFREQ , "{0}0", SFREQ ) ; 
                                        __context__.SourceCodeLine = 141;
                                        MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0} kHz", SFREQ ) ; 
                                        __context__.SourceCodeLine = 142;
                                        ITEMP = (ushort) ( 100 ) ; 
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 146;
                                        ITEMP = (ushort) ( 100 ) ; 
                                        } 
                                    
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 149;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 11))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 151;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SFREQ ) > 0 ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 153;
                                            SFREQ  .UpdateValue ( Functions.Left ( SFREQ ,  (int) ( (Functions.Length( SFREQ ) - 1) ) )  ) ; 
                                            __context__.SourceCodeLine = 154;
                                            MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0} kHz", SFREQ ) ; 
                                            __context__.SourceCodeLine = 155;
                                            ITEMP = (ushort) ( 100 ) ; 
                                            } 
                                        
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 158;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 12))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 160;
                                            SFREQ  .UpdateValue ( ""  ) ; 
                                            __context__.SourceCodeLine = 161;
                                            TUNER_FREQUENCY__DOLLAR__  .UpdateValue ( SFREQ  ) ; 
                                            __context__.SourceCodeLine = 162;
                                            ITEMP = (ushort) ( 100 ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 164;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 13))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 166;
                                                MakeString ( TO_DEVICE__DOLLAR__ , "{0}{1}\r", STUNER , SFREQ .PadLeft( 5, '0' )) ; 
                                                __context__.SourceCodeLine = 167;
                                                SFREQ  .UpdateValue ( ""  ) ; 
                                                __context__.SourceCodeLine = 168;
                                                ITEMP = (ushort) ( 100 ) ; 
                                                } 
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 173;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SFREQ ) < 5 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 175;
                                    MakeString ( SFREQ , "{0}{1:d}", SFREQ , (short)ITEMP) ; 
                                    __context__.SourceCodeLine = 176;
                                    MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0} kHz", SFREQ ) ; 
                                    __context__.SourceCodeLine = 177;
                                    ITEMP = (ushort) ( 100 ) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 181;
                                    ITEMP = (ushort) ( 100 ) ; 
                                    } 
                                
                                } 
                            
                            __context__.SourceCodeLine = 184;
                            break ; 
                            } 
                        
                        goto case 2 ;
                        case 2 : 
                        
                            { 
                            __context__.SourceCodeLine = 188;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITEMP >= 10 ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 190;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 10))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 192;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SFREQ ) < 5 ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 194;
                                        MakeString ( SFREQ , "{0}0", SFREQ ) ; 
                                        __context__.SourceCodeLine = 195;
                                        MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0} MHz", SFREQ ) ; 
                                        __context__.SourceCodeLine = 196;
                                        ITEMP = (ushort) ( 100 ) ; 
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 200;
                                        ITEMP = (ushort) ( 100 ) ; 
                                        } 
                                    
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 203;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 11))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 205;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SFREQ ) > 0 ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 207;
                                            SFREQ  .UpdateValue ( Functions.Left ( SFREQ ,  (int) ( (Functions.Length( SFREQ ) - 1) ) )  ) ; 
                                            __context__.SourceCodeLine = 208;
                                            MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0} MHz", SFREQ ) ; 
                                            __context__.SourceCodeLine = 209;
                                            ITEMP = (ushort) ( 100 ) ; 
                                            } 
                                        
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 212;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 12))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 214;
                                            SFREQ  .UpdateValue ( ""  ) ; 
                                            __context__.SourceCodeLine = 215;
                                            TUNER_FREQUENCY__DOLLAR__  .UpdateValue ( SFREQ  ) ; 
                                            __context__.SourceCodeLine = 216;
                                            ITEMP = (ushort) ( 100 ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 218;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMP == 13))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 220;
                                                MakeString ( TO_DEVICE__DOLLAR__ , "{0}{1}\r", STUNER , SFREQ .PadLeft( 5, '0' )) ; 
                                                __context__.SourceCodeLine = 221;
                                                SFREQ  .UpdateValue ( ""  ) ; 
                                                __context__.SourceCodeLine = 222;
                                                ITEMP = (ushort) ( 100 ) ; 
                                                } 
                                            
                                            else 
                                                { 
                                                __context__.SourceCodeLine = 226;
                                                ITEMP = (ushort) ( 100 ) ; 
                                                } 
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 231;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SFREQ ) < 5 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 233;
                                    MakeString ( SFREQ , "{0}{1:d}", SFREQ , (short)ITEMP) ; 
                                    __context__.SourceCodeLine = 234;
                                    MakeString ( TUNER_FREQUENCY__DOLLAR__ , "{0} MHz", SFREQ ) ; 
                                    __context__.SourceCodeLine = 235;
                                    ITEMP = (ushort) ( 100 ) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 239;
                                    ITEMP = (ushort) ( 100 ) ; 
                                    } 
                                
                                } 
                            
                            __context__.SourceCodeLine = 242;
                            break ; 
                            } 
                        
                        goto default;
                        default : 
                        
                            { 
                            __context__.SourceCodeLine = 246;
                            ITEMP = (ushort) ( 100 ) ; 
                            __context__.SourceCodeLine = 247;
                            break ; 
                            } 
                        break;
                        
                        } 
                        
                    
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object VOLUME_UP_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 255;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IVOL < 100 ))  ) ) 
                { 
                __context__.SourceCodeLine = 257;
                IVOLCHANGING = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 258;
                IVOL = (ushort) ( (IVOL + 1) ) ; 
                __context__.SourceCodeLine = 259;
                VOLUME_FB  .Value = (ushort) ( IVOL ) ; 
                __context__.SourceCodeLine = 260;
                MakeString ( TO_DEVICE__DOLLAR__ , "{0}{1:X2}\r", SVOLUME , IVOL) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object VOLUME_DOWN_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 266;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IVOL > 0 ))  ) ) 
            { 
            __context__.SourceCodeLine = 268;
            IVOLCHANGING = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 269;
            IVOL = (ushort) ( (IVOL - 1) ) ; 
            __context__.SourceCodeLine = 270;
            VOLUME_FB  .Value = (ushort) ( IVOL ) ; 
            __context__.SourceCodeLine = 271;
            MakeString ( TO_DEVICE__DOLLAR__ , "{0}{1:X2}\r", SVOLUME , IVOL) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VOLUME_DONE_OnRelease_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 277;
        IVOLCHANGING = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VOLUME_IN_OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 282;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( VOLUME_IN  .UshortValue <= 100 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( VOLUME_IN  .UshortValue >= 0 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (IVOLCHANGING == 0) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (VOLUME_IN  .UshortValue != IVOL) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 284;
            IVOL = (ushort) ( VOLUME_IN  .UshortValue ) ; 
            __context__.SourceCodeLine = 285;
            VOLUME_FB  .Value = (ushort) ( IVOL ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TUNER_COMMAND__DOLLAR___OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 291;
        STUNER  .UpdateValue ( TUNER_COMMAND__DOLLAR__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VOLUME_COMMAND__DOLLAR___OnChange_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 296;
        SVOLUME  .UpdateValue ( VOLUME_COMMAND__DOLLAR__  ) ; 
        
        
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
        
        __context__.SourceCodeLine = 305;
        IVOLCHANGING = (ushort) ( 0 ) ; 
        
        
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
    SFREQ  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
    STUNER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 6, this );
    SVOLUME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 6, this );
    
    VOLUME_UP = new Crestron.Logos.SplusObjects.DigitalInput( VOLUME_UP__DigitalInput__, this );
    m_DigitalInputList.Add( VOLUME_UP__DigitalInput__, VOLUME_UP );
    
    VOLUME_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( VOLUME_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( VOLUME_DOWN__DigitalInput__, VOLUME_DOWN );
    
    VOLUME_DONE = new Crestron.Logos.SplusObjects.DigitalInput( VOLUME_DONE__DigitalInput__, this );
    m_DigitalInputList.Add( VOLUME_DONE__DigitalInput__, VOLUME_DONE );
    
    TUNER_KEY = new InOutArray<DigitalInput>( 13, this );
    for( uint i = 0; i < 13; i++ )
    {
        TUNER_KEY[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( TUNER_KEY__DigitalInput__ + i, TUNER_KEY__DigitalInput__, this );
        m_DigitalInputList.Add( TUNER_KEY__DigitalInput__ + i, TUNER_KEY[i+1] );
    }
    
    VOLUME_IN = new Crestron.Logos.SplusObjects.AnalogInput( VOLUME_IN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( VOLUME_IN__AnalogSerialInput__, VOLUME_IN );
    
    SELECTED_TUNER = new Crestron.Logos.SplusObjects.AnalogInput( SELECTED_TUNER__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SELECTED_TUNER__AnalogSerialInput__, SELECTED_TUNER );
    
    VOLUME_FB = new Crestron.Logos.SplusObjects.AnalogOutput( VOLUME_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( VOLUME_FB__AnalogSerialOutput__, VOLUME_FB );
    
    TUNER_FREQUENCY__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__, TUNER_FREQUENCY__DOLLAR__ );
    
    TO_DEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TO_DEVICE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_DEVICE__DOLLAR____AnalogSerialOutput__, TO_DEVICE__DOLLAR__ );
    
    TUNER_COMMAND__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( TUNER_COMMAND__DOLLAR____AnalogSerialInput__, 6, this );
    m_StringInputList.Add( TUNER_COMMAND__DOLLAR____AnalogSerialInput__, TUNER_COMMAND__DOLLAR__ );
    
    VOLUME_COMMAND__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( VOLUME_COMMAND__DOLLAR____AnalogSerialInput__, 6, this );
    m_StringInputList.Add( VOLUME_COMMAND__DOLLAR____AnalogSerialInput__, VOLUME_COMMAND__DOLLAR__ );
    
    
    for( uint i = 0; i < 13; i++ )
        TUNER_KEY[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( TUNER_KEY_OnPush_0, false ) );
        
    VOLUME_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( VOLUME_UP_OnPush_1, false ) );
    VOLUME_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( VOLUME_DOWN_OnPush_2, false ) );
    VOLUME_DONE.OnDigitalRelease.Add( new InputChangeHandlerWrapper( VOLUME_DONE_OnRelease_3, false ) );
    VOLUME_IN.OnAnalogChange.Add( new InputChangeHandlerWrapper( VOLUME_IN_OnChange_4, false ) );
    TUNER_COMMAND__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( TUNER_COMMAND__DOLLAR___OnChange_5, false ) );
    VOLUME_COMMAND__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( VOLUME_COMMAND__DOLLAR___OnChange_6, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_ONKYO_TX_NR5008_PROCESSOR_V1_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint VOLUME_UP__DigitalInput__ = 0;
const uint VOLUME_DOWN__DigitalInput__ = 1;
const uint VOLUME_DONE__DigitalInput__ = 2;
const uint TUNER_KEY__DigitalInput__ = 3;
const uint VOLUME_IN__AnalogSerialInput__ = 0;
const uint SELECTED_TUNER__AnalogSerialInput__ = 1;
const uint TUNER_COMMAND__DOLLAR____AnalogSerialInput__ = 2;
const uint VOLUME_COMMAND__DOLLAR____AnalogSerialInput__ = 3;
const uint VOLUME_FB__AnalogSerialOutput__ = 0;
const uint TUNER_FREQUENCY__DOLLAR____AnalogSerialOutput__ = 1;
const uint TO_DEVICE__DOLLAR____AnalogSerialOutput__ = 2;

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
