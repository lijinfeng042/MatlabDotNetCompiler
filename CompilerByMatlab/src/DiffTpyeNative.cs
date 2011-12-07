/*
* MATLAB Compiler: 4.10 (R2009a)
* Date: Tue Dec 06 20:22:19 2011
* Arguments: "-B" "macro_default" "-W" "dotnet:TypeConvert,DiffTpye,0.0,private" "-d"
* "C:\Users\hp\Documents\我的微盘\Complier\TypeConvert\src" "-T" "link:lib" "-v"
* "class{DiffTpye:C:\Users\hp\Documents\我的微盘\Complier\magicCell.m,C:\Users\hp\Document
* s\我的微盘\Complier\magicChar.m,C:\Users\hp\Documents\我的微盘\Complier\magicDouble.m,C:
* \Users\hp\Documents\我的微盘\Complier\magicStruct.m}" 
*/

using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using MathWorks.MATLAB.NET.ComponentData;
#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace TypeConvertNative
{
  /// <summary>
  /// The DiffTpye class provides a CLS compliant, Object (native) interface to the
  /// M-functions contained in the files:
  /// <newpara></newpara>
  /// C:\Users\hp\Documents\我的微盘\Complier\magicCell.m
  /// <newpara></newpara>
  /// C:\Users\hp\Documents\我的微盘\Complier\magicChar.m
  /// <newpara></newpara>
  /// C:\Users\hp\Documents\我的微盘\Complier\magicDouble.m
  /// <newpara></newpara>
  /// C:\Users\hp\Documents\我的微盘\Complier\magicStruct.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class DiffTpye : IDisposable
  {
      #region Constructors

      /// <summary internal= "true">
      /// The static constructor instantiates and initializes the MATLAB Component
      /// Runtime instance.
      /// </summary>
      static DiffTpye()
      {
          if (MWMCR.MCRAppInitialized)
          {
              Assembly assembly= Assembly.GetExecutingAssembly();

              string ctfFilePath= assembly.Location;

              int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

              ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

              string ctfFileName = MCRComponentState.MCC_TypeConvert_name_data + ".ctf";

              Stream embeddedCtfStream = null;

              String[] resourceStrings = assembly.GetManifestResourceNames();

              foreach (String name in resourceStrings)
                {
                  if (name.Contains(ctfFileName))
                    {
                      embeddedCtfStream = assembly.GetManifestResourceStream(name);
                      break;
                    }
                }
              mcr= new MWMCR(MCRComponentState.MCC_TypeConvert_name_data,
                             MCRComponentState.MCC_TypeConvert_root_data,
                             MCRComponentState.MCC_TypeConvert_public_data,
                             MCRComponentState.MCC_TypeConvert_session_data,
                             MCRComponentState.MCC_TypeConvert_matlabpath_data,
                             MCRComponentState.MCC_TypeConvert_classpath_data,
                             MCRComponentState.MCC_TypeConvert_libpath_data,
                             MCRComponentState.MCC_TypeConvert_mcr_application_options,
                             MCRComponentState.MCC_TypeConvert_mcr_runtime_options,
                             MCRComponentState.MCC_TypeConvert_mcr_pref_dir,
                             MCRComponentState.MCC_TypeConvert_set_warning_state,
                             ctfFilePath, embeddedCtfStream, true);
          }
          else
          {
              throw new ApplicationException("MWArray assembly could not be initialized");
          }
      }


      /// <summary>
      /// Constructs a new instance of the DiffTpye class.
      /// </summary>
      public DiffTpye()
      {
      }


      #endregion Constructors

      #region Finalize

      /// <summary internal= "true">
      /// Class destructor called by the CLR garbage collector.
      /// </summary>
      ~DiffTpye()
      {
          Dispose(false);
      }


      /// <summary>
      /// Frees the native resources associated with this object
      /// </summary>
      public void Dispose()
      {
          Dispose(true);

          GC.SuppressFinalize(this);
      }


      /// <summary internal= "true">
      /// Internal dispose function
      /// </summary>
      protected virtual void Dispose(bool disposing)
      {
          if (!disposed)
          {
              disposed= true;

              if (disposing)
              {
                  // Free managed resources;
              }

              // Free native resources
          }
      }


      #endregion Finalize

      #region Methods

      /// <summary>
      /// Provides a single output, 0-input Object interface to the magicCell M-function.
      /// </summary>
      /// <remarks>
      /// </remarks>
      /// <returns>An Object containing the first output argument.</returns>
      ///
      public Object magicCell()
      {
          return mcr.EvaluateFunction("magicCell", new Object[]{});
      }


      /// <summary>
      /// Provides a single output, 1-input Object interface to the magicCell M-function.
      /// </summary>
      /// <remarks>
      /// </remarks>
      /// <param name="sizeVal">Input argument #1</param>
      /// <returns>An Object containing the first output argument.</returns>
      ///
      public Object magicCell(Object sizeVal)
      {
          return mcr.EvaluateFunction("magicCell", sizeVal);
      }


      /// <summary>
      /// Provides the standard 0-input Object interface to the magicCell M-function.
      /// </summary>
      /// <remarks>
      /// </remarks>
      /// <param name="numArgsOut">The number of output arguments to return.</param>
      /// <returns>An Array of length "numArgsOut" containing the output
      /// arguments.</returns>
      ///
      public Object[] magicCell(int numArgsOut)
      {
          return mcr.EvaluateFunction(numArgsOut, "magicCell", new Object[]{});
      }


      /// <summary>
      /// Provides the standard 1-input Object interface to the magicCell M-function.
      /// </summary>
      /// <remarks>
      /// </remarks>
      /// <param name="numArgsOut">The number of output arguments to return.</param>
      /// <param name="sizeVal">Input argument #1</param>
      /// <returns>An Array of length "numArgsOut" containing the output
      /// arguments.</returns>
      ///
      public Object[] magicCell(int numArgsOut, Object sizeVal)
      {
          return mcr.EvaluateFunction(numArgsOut, "magicCell", sizeVal);
      }


      /// <summary>
      /// Provides a single output, 0-input Object interface to the magicChar M-function.
      /// </summary>
      /// <remarks>
      /// </remarks>
      /// <returns>An Object containing the first output argument.</returns>
      ///
      public Object magicChar()
      {
          return mcr.EvaluateFunction("magicChar", new Object[]{});
      }


      /// <summary>
      /// Provides a single output, 1-input Object interface to the magicChar M-function.
      /// </summary>
      /// <remarks>
      /// </remarks>
      /// <param name="sizeVal">Input argument #1</param>
      /// <returns>An Object containing the first output argument.</returns>
      ///
      public Object magicChar(Object sizeVal)
      {
          return mcr.EvaluateFunction("magicChar", sizeVal);
      }


      /// <summary>
      /// Provides the standard 0-input Object interface to the magicChar M-function.
      /// </summary>
      /// <remarks>
      /// </remarks>
      /// <param name="numArgsOut">The number of output arguments to return.</param>
      /// <returns>An Array of length "numArgsOut" containing the output
      /// arguments.</returns>
      ///
      public Object[] magicChar(int numArgsOut)
      {
          return mcr.EvaluateFunction(numArgsOut, "magicChar", new Object[]{});
      }


      /// <summary>
      /// Provides the standard 1-input Object interface to the magicChar M-function.
      /// </summary>
      /// <remarks>
      /// </remarks>
      /// <param name="numArgsOut">The number of output arguments to return.</param>
      /// <param name="sizeVal">Input argument #1</param>
      /// <returns>An Array of length "numArgsOut" containing the output
      /// arguments.</returns>
      ///
      public Object[] magicChar(int numArgsOut, Object sizeVal)
      {
          return mcr.EvaluateFunction(numArgsOut, "magicChar", sizeVal);
      }


      /// <summary>
      /// Provides a single output, 0-input Object interface to the magicDouble
      /// M-function.
      /// </summary>
      /// <remarks>
      /// </remarks>
      /// <returns>An Object containing the first output argument.</returns>
      ///
      public Object magicDouble()
      {
          return mcr.EvaluateFunction("magicDouble", new Object[]{});
      }


      /// <summary>
      /// Provides a single output, 1-input Object interface to the magicDouble
      /// M-function.
      /// </summary>
      /// <remarks>
      /// </remarks>
      /// <param name="sizeVal">Input argument #1</param>
      /// <returns>An Object containing the first output argument.</returns>
      ///
      public Object magicDouble(Object sizeVal)
      {
          return mcr.EvaluateFunction("magicDouble", sizeVal);
      }


      /// <summary>
      /// Provides the standard 0-input Object interface to the magicDouble M-function.
      /// </summary>
      /// <remarks>
      /// </remarks>
      /// <param name="numArgsOut">The number of output arguments to return.</param>
      /// <returns>An Array of length "numArgsOut" containing the output
      /// arguments.</returns>
      ///
      public Object[] magicDouble(int numArgsOut)
      {
          return mcr.EvaluateFunction(numArgsOut,
                                      "magicDouble", new Object[]{});
      }


      /// <summary>
      /// Provides the standard 1-input Object interface to the magicDouble M-function.
      /// </summary>
      /// <remarks>
      /// </remarks>
      /// <param name="numArgsOut">The number of output arguments to return.</param>
      /// <param name="sizeVal">Input argument #1</param>
      /// <returns>An Array of length "numArgsOut" containing the output
      /// arguments.</returns>
      ///
      public Object[] magicDouble(int numArgsOut, Object sizeVal)
      {
          return mcr.EvaluateFunction(numArgsOut, "magicDouble", sizeVal);
      }


      /// <summary>
      /// Provides a single output, 0-input Object interface to the magicStruct
      /// M-function.
      /// </summary>
      /// <remarks>
      /// </remarks>
      /// <returns>An Object containing the first output argument.</returns>
      ///
      public Object magicStruct()
      {
          return mcr.EvaluateFunction("magicStruct", new Object[]{});
      }


      /// <summary>
      /// Provides a single output, 1-input Object interface to the magicStruct
      /// M-function.
      /// </summary>
      /// <remarks>
      /// </remarks>
      /// <param name="sizeVal">Input argument #1</param>
      /// <returns>An Object containing the first output argument.</returns>
      ///
      public Object magicStruct(Object sizeVal)
      {
          return mcr.EvaluateFunction("magicStruct", sizeVal);
      }


      /// <summary>
      /// Provides the standard 0-input Object interface to the magicStruct M-function.
      /// </summary>
      /// <remarks>
      /// </remarks>
      /// <param name="numArgsOut">The number of output arguments to return.</param>
      /// <returns>An Array of length "numArgsOut" containing the output
      /// arguments.</returns>
      ///
      public Object[] magicStruct(int numArgsOut)
      {
          return mcr.EvaluateFunction(numArgsOut,
                                      "magicStruct", new Object[]{});
      }


      /// <summary>
      /// Provides the standard 1-input Object interface to the magicStruct M-function.
      /// </summary>
      /// <remarks>
      /// </remarks>
      /// <param name="numArgsOut">The number of output arguments to return.</param>
      /// <param name="sizeVal">Input argument #1</param>
      /// <returns>An Array of length "numArgsOut" containing the output
      /// arguments.</returns>
      ///
      public Object[] magicStruct(int numArgsOut, Object sizeVal)
      {
          return mcr.EvaluateFunction(numArgsOut, "magicStruct", sizeVal);
      }


      /// <summary>
      /// This method will cause a MATLAB figure window to behave as a modal dialog box.
      /// The method will not return until all the figure windows associated with this
      /// component have been closed.
      /// </summary>
      /// <remarks>
      /// An application should only call this method when required to keep the
      /// MATLAB figure window from disappearing.  Other techniques, such as calling
      /// Console.ReadLine() from the application should be considered where
      /// possible.</remarks>
      ///
      public void WaitForFiguresToDie()
      {
          mcr.WaitForFiguresToDie();
      }


      
      #endregion Methods

      #region Class Members

      private static MWMCR mcr= null;

      private bool disposed= false;

      #endregion Class Members
  }
}
