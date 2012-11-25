////////////////////////////////////////////////////////////////////////////////////////////////////////
// LLBLGen Pro LINQPad driver is (c) 2002-2012 Solutions Design. All rights reserved.
// http://www.llblgen.com
////////////////////////////////////////////////////////////////////////////////////////////////////////
// COPYRIGHTS:
// Copyright (c)2002-2012 Solutions Design. All rights reserved.
// http://www.llblgen.com
// 
// The LLBLGen Pro LINQPad driver sourcecode is released under the following license (BSD2):
// ----------------------------------------------------------------------
// Redistribution and use in source and binary forms, with or without modification, 
// are permitted provided that the following conditions are met: 
//
// 1) Redistributions of source code must retain the above copyright notice, this list of 
//    conditions and the following disclaimer. 
// 2) Redistributions in binary form must reproduce the above copyright notice, this list of 
//    conditions and the following disclaimer in the documentation and/or other materials 
//    provided with the distribution. 
// 
// THIS SOFTWARE IS PROVIDED BY SOLUTIONS DESIGN ``AS IS'' AND ANY EXPRESS OR IMPLIED WARRANTIES, 
// INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A 
// PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL SOLUTIONS DESIGN OR CONTRIBUTORS BE LIABLE FOR 
// ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
// NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR 
// BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, 
// STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE. 
//
// The views and conclusions contained in the software and documentation are those of the authors 
// and should not be interpreted as representing official policies, either expressed or implied, 
// of Solutions Design. 
//
//////////////////////////////////////////////////////////////////////
// Contributers to the code:
//		- Frans Bouma [FB]
//////////////////////////////////////////////////////////////////////
// Special thanks to:
//		- Jeremy Thomas
//////////////////////////////////////////////////////////////////////

using System.Diagnostics;
using LINQPad.Extensibility.DataContext;

namespace AW.LLBLGen.DataContextDriver
{
  /// <summary>
  ///   Simple trace listener which is bound to the ORMPersistenceExecution trace and emits the executed query messages to the Linq pad output.
  /// </summary>
  public class ORMPersistenceExecutionListener : TraceListener
  {
    #region Class Member Declarations

    private readonly QueryExecutionManager _executionManager;

    #endregion

    /// <summary>
    ///   Initializes a new instance of the <see cref="ORMPersistenceExecutionListener" /> class.
    /// </summary>
    /// <param name="executionManager">The execution manager.</param>
    public ORMPersistenceExecutionListener(QueryExecutionManager executionManager)
    {
      _executionManager = executionManager;
    }

    /// <summary>
    ///   When overridden in a derived class, writes the specified message to the listener you create in the derived class.
    /// </summary>
    /// <param name="message">A message to write.</param>
    public override void Write(string message)
    {
      if (string.IsNullOrEmpty(message.Trim()))
        return;
      if (NeedIndent)
        WriteIndent();
      _executionManager.SqlTranslationWriter.Write(message);
    }

    /// <summary>
    ///   When overridden in a derived class, writes a message to the listener you create in the derived class, followed by a line terminator.
    /// </summary>
    /// <param name="message">A message to write.</param>
    public override void WriteLine(string message)
    {
      if (string.IsNullOrEmpty(message.Trim()))
        return;
      if (NeedIndent)
        WriteIndent();
      _executionManager.SqlTranslationWriter.WriteLine(message);
    }

    /// <summary>
    ///   When overridden in a derived class, flushes the output buffer.
    /// </summary>
    public override void Flush()
    {
      _executionManager.SqlTranslationWriter.Flush();
    }
  }
}