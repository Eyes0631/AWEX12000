// ============================================================================
// Copyright (c) 2010  IOSS GmbH
// All Rights Reserved.
// ============================================================================


// ============================================================================
//
//      AppCsLogger  -  Very simple C# logger
//
// ============================================================================
//
//      File:     Logger.cs                  Type:         Implementation
//
//      Date:     08.02.2010                 Last Change:  09.02.2010
//
//      Author:   Thomas M. Schlageter
//
//      Methods:  Logger                -  constructor
//
//                hide                  -  hide log window
//                isLogging             -  return true if logging enabled
//                logMessage            -  append message
//                reorgLog              -  reorganize log messages
//                show                  -  show log window
//
// ============================================================================


using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;


namespace AppCsLogger
{
    public class Logger
    {
        // ====================================================================
        /// <summary>
        /// Private member variables.
        /// </summary>
        // ====================================================================

        private bool logging = true;

        private int maxLines = 28;		// visable lines
        private int oldLines = 5;		// remaining old lines

        private static int entry = 0;		// entry number

        private System.Windows.Forms.TextBox logBox;


        // ====================================================================
        /// <summary>
        /// Constructor: Initialize Logger.
        /// </summary>
        // ====================================================================

        public Logger(System.Windows.Forms.TextBox tb,
                       bool l)
        {
            // TODO: Use Factory Pattern to create version specific variants
            logBox = tb;
            logging = l;

            if (!logging)
                hide();

            logBox.Text += "\r\n";
        }


        // ====================================================================
        /// <summary>
        /// Add message to log text box.
        /// </summary>
        /// <param name="msg"> message to add.</param>
        // ====================================================================

        public void logMessage(string msg)
        {
            // no logging: then just return
            if (!this.logging)
                return;


            // reorganize log messages
            reorgLog(logBox.Text);


            // append new log message
            logBox.Text += entry + ":\t";
            logBox.Text += msg;
            logBox.Text += "\r\n";


            // increment entry counter
            entry++;
        }


        // ====================================================================
        /// <summary>
        /// Reorganize log messages.
        /// </summary>
        /// <param name="msg"> message to add.</param>
        // ====================================================================

        private void reorgLog(string t)
        {
            char[] sep = { '\n' };
            string[] old = t.Split(sep);
            int l = old.Length;


            // check whether to reorganize the log or not
            if (l < maxLines)
                return;


            // reorganize log messages
            logBox.Clear();

            for (int i = oldLines; i > 0; i--)
            {
                logBox.Text += old[l - i];
                logBox.Text += "\r\n";
            }
        }


        // ====================================================================
        /// <summary>
        /// Check for logging enabled.
        /// </summary>
        /// <return> true if enabled.</return>
        // ====================================================================

        public bool isLogging()
        {
            return logging;
        }


        // ====================================================================
        /// <summary>
        /// Show log window.
        /// </summary>
        // ====================================================================

        public void show()
        {
            logBox.Visible = true;

            logging = true;
        }


        // ====================================================================
        /// <summary>
        /// Hide log window.
        /// </summary>
        // ====================================================================

        public void hide()
        {
            logBox.Visible = false;

            logging = false;
        }
    }
}
