﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18052
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace LosslessAviRgbConverter {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource1 {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource1() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LosslessAviRgbConverter.Resource1", typeof(Resource1).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 SetWorkingDir(&quot;$avspluginpath$&quot;)
        ///
        ///LoadPlugin(&quot;dither-1.23.0\avstp.dll&quot;)
        ///LoadPlugin(&quot;SmoothAdjust-v2.80\avs-2.6.x\x86\SmoothAdjust.dll&quot;)
        ///LoadPlugin(&quot;masktools-26-for-2.6alpha4\mt_masktools-26.dll&quot;)
        ///LoadPlugin(&quot;nnedi3-0.9.4\nnedi3.dll&quot;)
        ///Import(&quot;masktools-v2.0a48\masktools\LimitedSharpenFaster.avsi&quot;)
        ///Import(&quot;masktools-v2.0a48\masktools\mfToon-v0.54.avsi&quot;)
        ///Import(&quot;masktools-v2.0a48\masktools\vmToon-v0.74.avsi&quot;)
        ///LoadPlugin(&quot;dither-1.23.0\dither.dll&quot;)
        ///Import(&quot;dither-1.23.0\dither.avsi&quot;)
        ///Import(&quot;O16mod_ [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string AvsScriptTemplete {
            get {
                return ResourceManager.GetString("AvsScriptTemplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 --x264-binary &quot;$x264execute$&quot; --input-csp i444 --output-csp i444 --input-depth $depth$   --input-range pc --range pc --colormatrix $colormatrix$  --crf $crf$ --preset $preset$  $tune$     $userargs$   --output  &quot;$outputfile$&quot; &quot;$intputavs$&quot; 的本地化字符串。
        /// </summary>
        internal static string x264Line {
            get {
                return ResourceManager.GetString("x264Line", resourceCulture);
            }
        }
    }
}
