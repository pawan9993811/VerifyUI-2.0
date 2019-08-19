using NLog;
using NLog.Config;
using NLog.LayoutRenderers;
using NLog.Targets;
using NLog.Targets.Wrappers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pega.TestAutomation.GenericUtility.Logging
{
    public class NLogger
    {
        private static NLogger instance = null;
        private readonly Logger log = LogManager.GetCurrentClassLogger();
        protected LogLevel maxLevel = LogLevel.Info;
        protected LogLevel minLevel = LogLevel.Trace;
        protected LogLevel exceptionLevel = LogLevel.Error;

        public static NLogger Instance
        {
            get
            {
                if (instance == null)
                    instance = new NLogger();
                return instance;
            }
        }

        public NLogger()
        {
            SetupLoggingConfiguration();
        }

        

        public void Log(UnitLogLevel level, string msg, [CallerMemberName]string methodName = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            StackFrame frame = new StackFrame(1, false);
            MethodBase method = frame.GetMethod();
            Type className = method.DeclaringType;
            msg = msg + " | Method Name: " + className + "." + methodName + " | Line Number: " + sourceLineNumber;

            switch (level)
            {
                case UnitLogLevel.Trace:
                    log.Log(LogLevel.Trace, msg);
                    break;
                case UnitLogLevel.Debug:
                    log.Log(LogLevel.Debug, msg);
                    break;
                case UnitLogLevel.Info:
                    log.Log(LogLevel.Info, msg);
                    break;
                case UnitLogLevel.Warning:
                    log.Log(LogLevel.Warn, msg);
                    break;
                case UnitLogLevel.Error:
                    log.Log(LogLevel.Error, msg);
                    break;
                case UnitLogLevel.Fatal:
                    log.Log(LogLevel.Fatal, msg);
                    break;
                default:
                    break;
            }
        }

        public void Log(UnitLogLevel level, Exception e)
        {
            switch (level)
            {
                case UnitLogLevel.Trace:
                    log.Log(LogLevel.Trace, e);
                    break;
                case UnitLogLevel.Debug:
                    log.Log(LogLevel.Debug, e);
                    break;
                case UnitLogLevel.Info:
                    log.Log(LogLevel.Info, e);
                    break;
                case UnitLogLevel.Warning:
                    log.Log(LogLevel.Warn, e);
                    break;
                case UnitLogLevel.Error:
                    log.Log(LogLevel.Error, e);
                    break;
                case UnitLogLevel.Fatal:
                    log.Log(LogLevel.Fatal, e);
                    break;
                default:
                    break;
            }
        }

        //class TestLogManager
        //{
        //    // A Logger dispenser for the current configuration (Remember to call Flush on application exit)
        //    public static LogFactory Instance { get { return instance.Value; } }
        //    private static Lazy<LogFactory> instance = new Lazy<LogFactory>(BuildLogFactory);


        //    private static LogFactory BuildLogFactory()
        //    {
        //        // Initialize LogFactory object
        //        LogFactory logFactory = new LogFactory();

        //        // Initialize LogFactory Configuration
        //        LoggingConfiguration config = new LoggingConfiguration();


        //        // Register the custom layout to show stack trace in logs
        //        LayoutRenderer.Register("IndentationLayout", typeof(IndentationLayoutRenderer)); //no space

        //        // Initialize File Target
        //        var fileTarget = new FileTarget("File Target")
        //        {
        //            FileName = "${basedir}/logs/logTest.xml",
        //            DeleteOldFileOnStartup = true, // Deletes old log file every time log is called. Set to true simply for testing purposes
        //            KeepFileOpen = true, // Keeps file open regardless of logger status. (Increases performance)
        //            OpenFileCacheTimeout = 30, // Max number of seconds file is kept open. (Increases performance, but the value will scale with the scope of logger implementation)
        //            Layout = "${IndentationLayout} ${longdate} | ${level:uppercase=true} | ${logger} | ${message} | ${callsite:className=true:fileName=false:includeSourcePath=false:methodName=true}" //use IndentationLayout
        //        };


        //        // Initialize the AsyncWrapper for the fileTarget
        //        AsyncTargetWrapper fileWrapper = new AsyncTargetWrapper();
        //        fileWrapper.WrappedTarget = fileTarget;
        //        fileWrapper.QueueLimit = 5000;  // Limits number of requests in the request queue (Improves performance)
        //        fileWrapper.OverflowAction = AsyncTargetWrapperOverflowAction.Block; // Blocks incoming requests until request queue if has space

        //        // Initialize the AsyncFlushTargetWrapper for the FileWrapper
        //        AutoFlushTargetWrapper fileFlushWrapper = new AutoFlushTargetWrapper();
        //        fileFlushWrapper.WrappedTarget = fileWrapper;

        //        // This condition controls when the log is flushed. Set the LogLevel to be equivalent to the maximum level specified in the targetRule
        //        fileFlushWrapper.Condition = "level >= LogLevel.Info";

        //        // Adding the target to the config
        //        config.AddTarget("file", fileFlushWrapper);

        //        // Creating the Log Level rules for each target and adding them to the config
        //        var fileRule = new LoggingRule("*", fileTarget);
        //        fileRule.EnableLoggingForLevel(exceptionLevel);
        //        fileRule.EnableLoggingForLevels(minLevel, maxLevel);
        //        config.LoggingRules.Add(fileRule);

        //        // Assigning the configuration to the logger
        //        logFactory.Configuration = config;

        //        return logFactory;
        //    }
        //}
        private void SetupLoggingConfiguration()
        {

            // Intialize Config Object
            LoggingConfiguration config = new LoggingConfiguration();

            LayoutRenderer.Register("IndentationLayout", typeof(IndentationLayoutRenderer)); //no space

            /*
           // Initialize Console Target
           var consoleTarget = new ColoredConsoleTarget("Console Target")
           {
               Layout = @"${time} ${longdate} ${uppercase: ${level}} ${logger} ${message} ${exception: format=ToString}"
           };

           // Initialize the AsyncWrapper for the ConsoleTarget
           AsyncTargetWrapper consoleWrapper = new AsyncTargetWrapper();
           consoleWrapper.WrappedTarget = consoleTarget;
           consoleWrapper.OverflowAction = AsyncTargetWrapperOverflowAction.Block;
           consoleWrapper.QueueLimit = 5000;

           // Initialize the AsyncFlushTargetWrapper for the ConsoleWrapper
           AutoFlushTargetWrapper consoleFlushWrapper = new AutoFlushTargetWrapper();
           consoleFlushWrapper.WrappedTarget = consoleWrapper;

           // This condition controls when the log is flushed. Set the LogLevel to be equivalent to the maximum level specified in the targetRule
           consoleFlushWrapper.Condition = "level >= LogLevel.Info";

           // Adding the target to the config
           config.AddTarget("console", consoleFlushWrapper);
           */


            // Initialize File Target
            var fileTarget = new FileTarget("File Target")
            {
                FileName = @"${basedir}\logs\Robotics Automation Log.xml",
                DeleteOldFileOnStartup = true, // Deletes old log file every time log is called. Set to true simply for testing purposes
                KeepFileOpen = true, // Keeps file open regardless of logger status. (Increases performance)
                OpenFileCacheTimeout = 30, // Max number of seconds file is kept open. (Increases performance, but the value will scale with the scope of logger implementation)
                Layout = @"${IndentationLayout} ${date:format=yyyy-MM-dd HH\:mm\:ss} | ${level:uppercase=true} | ${message}" //use IndentationLayout
            };

            //// XmlLayout Configuration
            //var XmlLayout = new XmlLayout();



            //XmlLayout.IndentXml = true;
            //XmlLayout.ElementName = "Automated Test";
            //XmlLayout.ElementValue = "Current Test";  // Unit Test name can be entered into here so each log entry will include Unit Test
            //XmlLayout.MaxRecursionLimit = 10;


            //XmlLayout.Attributes.Add(new XmlAttribute("Time", "${longdate}"));
            //XmlLayout.Attributes.Add(new XmlAttribute("Level", "${level:upperCase=true"));
            //XmlLayout.Elements.Add(new XmlElement("Output", "${message}"));
            //XmlLayout.Elements.Add(new XmlElement("Location", "${callsite:methodName=true}"));

            //fileTarget.Layout = XmlLayout;


            // Initialize the AsyncWrapper for the fileTarget
            AsyncTargetWrapper fileWrapper = new AsyncTargetWrapper();
            fileWrapper.WrappedTarget = fileTarget;
            fileWrapper.QueueLimit = 5000;  // Limits number of requests in the request queue (Improves performance)
            fileWrapper.OverflowAction = AsyncTargetWrapperOverflowAction.Block; // Blocks incoming requests until request queue if has space

            // Initialize the AsyncFlushTargetWrapper for the FileWrapper
            AutoFlushTargetWrapper fileFlushWrapper = new AutoFlushTargetWrapper();
            fileFlushWrapper.WrappedTarget = fileWrapper;

            /*
            // Initiliaze Database Target
            var dbTarget = new DatabaseTarget
            {
                ConnectionString = WhatINeed,
                DBProvider = "MongoServer",
                Name = "Mongo",
                CommandText =
                    @"insert into dbo.Log (
                        Logged, Level, Message, Username, Url, Logger, Callsite, Exception, Stacktrace, remoteAddress
                    ) values(
                        @Logged, @Level, @Message, @Username, @Url, @Logger, @Callsite, @Exception, @Stacktrace, @remoteAddress
                    );"
            };

            // Adding all database parameters to pass through Mongo
            dbTarget.Parameters.Add(new DatabaseParameterInfo("@Logged", "${date}"));
            dbTarget.Parameters.Add(new DatabaseParameterInfo("@Level", "${level}"));
            dbTarget.Parameters.Add(new DatabaseParameterInfo("@Message", "${message}"));
            dbTarget.Parameters.Add(new DatabaseParameterInfo("@Username", "${identity}"));
            dbTarget.Parameters.Add(new DatabaseParameterInfo("@Url", "${I need this}"));
            dbTarget.Parameters.Add(new DatabaseParameterInfo("@Logger", "${logger}"));
            dbTarget.Parameters.Add(new DatabaseParameterInfo("@Callsite", "${callsite}"));
            dbTarget.Parameters.Add(new DatabaseParameterInfo("@Exception", "${exception:format=toString}"));
            dbTarget.Parameters.Add(new DatabaseParameterInfo("@StackTrace", "${stacktrace}"));

            // Add the target to the config
            config.AddTarget("database", dbTarget);

            var databaseRule = new LoggingRule("DatabaseRule", LogLevel.Trace, dbTarget);
            config.LoggingRules.Add(databaseRule);
            */

            // This condition controls when the log is flushed. Set the LogLevel to be equivalent to the maximum level specified in the targetRule
            fileFlushWrapper.Condition = "level >= LogLevel.Info";

            // Adding the target to the config
            config.AddTarget("file", fileFlushWrapper);

            // Creating the Log Level rules for each target and adding them to the config
            var fileRule = new LoggingRule("*", fileTarget);
            fileRule.EnableLoggingForLevel(exceptionLevel);
            fileRule.EnableLoggingForLevels(minLevel, maxLevel);
            config.LoggingRules.Add(fileRule);

            /*
            var consoleRule = new LoggingRule("*", consoleTarget);
            consoleRule.EnableLoggingForLevels(LogLevel.Trace, LogLevel.Info);
            consoleRule.EnableLoggingForLevel(LogLevel.Error);
            config.LoggingRules.Add(consoleRule);
            */

            // Assigning the configuration to the logger
            LogManager.Configuration = config;
        }
    }
    public enum UnitLogLevel
    {
        Trace = 0,
        Debug = 1,
        Info = 2,
        Warning = 3,
        Error = 4,
        Fatal = 5

    }

    [LayoutRenderer("IndentationLayout")]
    public sealed class IndentationLayoutRenderer : LayoutRenderer
    {

        // Get current stack depth, insert padding spaces
        public static StackTrace st = new StackTrace();
        public static int newIndent = st.FrameCount;

        // Value to substract from stack count
        public static int _ignore = 53;

        public int ignoreBuffer = newIndent - _ignore;
        public int indentBuffer = newIndent - _ignore;
        // Value to pad with.
        public string iPadding = " ";

        // Set the number of (top) stackframes to ignore
        public int Ignore
        {
            get { return _ignore; }
            set { _ignore = value; }
        }

        // Set the padding value
        public string IndentationPadding
        {
            get { return iPadding; }
            set { iPadding = value; }
        }

        protected override void Append(StringBuilder builder, LogEventInfo ev)
        {

            newIndent = indentBuffer - ignoreBuffer;

            for (int i = 0; i < newIndent; i++)
            {
                builder.Append(iPadding);
            }

            indentBuffer++;
        }
    }
}
