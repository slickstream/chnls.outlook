﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chnls.Utils
{
    class OutlookEmailHeaderConst
    {
        public const string EMAIL_HEADER =
           @"<html xmlns:v=""urn:schemas-microsoft-com:vml"" xmlns:o=""urn:schemas-microsoft-com:office:office"" xmlns:w=""urn:schemas-microsoft-com:office:word"" xmlns:m=""http://schemas.microsoft.com/office/2004/12/omml"" xmlns=""http://www.w3.org/TR/REC-html40""><head><META HTTP-EQUIV=""Content-Type"" CONTENT=""text/html; charset=us-ascii""><meta name=ProgId content=Word.Document><meta name=Generator content=""Microsoft Word 14""><meta name=Originator content=""Microsoft Word 14""><link rel=File-List href=""cid:filelist.xml@01CEEF7E.42BE0430""><!--[if gte mso 9]><xml>
<o:OfficeDocumentSettings>
<o:AllowPNG/>
</o:OfficeDocumentSettings>
</xml><![endif]--><link rel=themeData href=""~~themedata~~""><link rel=colorSchemeMapping href=""~~colorschememapping~~""><!--[if gte mso 9]><xml>
<w:WordDocument>
<w:TrackMoves/>
<w:TrackFormatting/>
<w:EnvelopeVis/>
<w:ValidateAgainstSchemas/>
<w:SaveIfXMLInvalid>false</w:SaveIfXMLInvalid>
<w:IgnoreMixedContent>false</w:IgnoreMixedContent>
<w:AlwaysShowPlaceholderText>false</w:AlwaysShowPlaceholderText>
<w:DoNotPromoteQF/>
<w:LidThemeOther>EN-US</w:LidThemeOther>
<w:LidThemeAsian>X-NONE</w:LidThemeAsian>
<w:LidThemeComplexScript>X-NONE</w:LidThemeComplexScript>
<w:Compatibility>
<w:DoNotExpandShiftReturn/>
<w:BreakWrappedTables/>
<w:SplitPgBreakAndParaMark/>
<w:EnableOpenTypeKerning/>
</w:Compatibility>
<m:mathPr>
<m:mathFont m:val=""Cambria Math""/>
<m:brkBin m:val=""before""/>
<m:brkBinSub m:val=""&#45;-""/>
<m:smallFrac m:val=""off""/>
<m:dispDef/>
<m:lMargin m:val=""0""/>
<m:rMargin m:val=""0""/>
<m:defJc m:val=""centerGroup""/>
<m:wrapIndent m:val=""1440""/>
<m:intLim m:val=""subSup""/>
<m:naryLim m:val=""undOvr""/>
</m:mathPr></w:WordDocument>
</xml><![endif]--><!--[if gte mso 9]><xml>
<w:LatentStyles DefLockedState=""false"" DefUnhideWhenUsed=""true"" DefSemiHidden=""true"" DefQFormat=""false"" DefPriority=""99"" LatentStyleCount=""267"">
<w:LsdException Locked=""false"" Priority=""0"" SemiHidden=""false"" UnhideWhenUsed=""false"" QFormat=""true"" Name=""Normal""/>
<w:LsdException Locked=""false"" Priority=""9"" SemiHidden=""false"" UnhideWhenUsed=""false"" QFormat=""true"" Name=""heading 1""/>
<w:LsdException Locked=""false"" Priority=""9"" QFormat=""true"" Name=""heading 2""/>
<w:LsdException Locked=""false"" Priority=""9"" QFormat=""true"" Name=""heading 3""/>
<w:LsdException Locked=""false"" Priority=""9"" QFormat=""true"" Name=""heading 4""/>
<w:LsdException Locked=""false"" Priority=""9"" QFormat=""true"" Name=""heading 5""/>
<w:LsdException Locked=""false"" Priority=""9"" QFormat=""true"" Name=""heading 6""/>
<w:LsdException Locked=""false"" Priority=""9"" QFormat=""true"" Name=""heading 7""/>
<w:LsdException Locked=""false"" Priority=""9"" QFormat=""true"" Name=""heading 8""/>
<w:LsdException Locked=""false"" Priority=""9"" QFormat=""true"" Name=""heading 9""/>
<w:LsdException Locked=""false"" Priority=""39"" Name=""toc 1""/>
<w:LsdException Locked=""false"" Priority=""39"" Name=""toc 2""/>
<w:LsdException Locked=""false"" Priority=""39"" Name=""toc 3""/>
<w:LsdException Locked=""false"" Priority=""39"" Name=""toc 4""/>
<w:LsdException Locked=""false"" Priority=""39"" Name=""toc 5""/>
<w:LsdException Locked=""false"" Priority=""39"" Name=""toc 6""/>
<w:LsdException Locked=""false"" Priority=""39"" Name=""toc 7""/>
<w:LsdException Locked=""false"" Priority=""39"" Name=""toc 8""/>
<w:LsdException Locked=""false"" Priority=""39"" Name=""toc 9""/>
<w:LsdException Locked=""false"" Priority=""35"" QFormat=""true"" Name=""caption""/>
<w:LsdException Locked=""false"" Priority=""10"" SemiHidden=""false"" UnhideWhenUsed=""false"" QFormat=""true"" Name=""Title""/>
<w:LsdException Locked=""false"" Priority=""1"" Name=""Default Paragraph Font""/>
<w:LsdException Locked=""false"" Priority=""11"" SemiHidden=""false"" UnhideWhenUsed=""false"" QFormat=""true"" Name=""Subtitle""/>
<w:LsdException Locked=""false"" Priority=""22"" SemiHidden=""false"" UnhideWhenUsed=""false"" QFormat=""true"" Name=""Strong""/>
<w:LsdException Locked=""false"" Priority=""20"" SemiHidden=""false"" UnhideWhenUsed=""false"" QFormat=""true"" Name=""Emphasis""/>
<w:LsdException Locked=""false"" Priority=""59"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Table Grid""/>
<w:LsdException Locked=""false"" UnhideWhenUsed=""false"" Name=""Placeholder Text""/>
<w:LsdException Locked=""false"" Priority=""1"" SemiHidden=""false"" UnhideWhenUsed=""false"" QFormat=""true"" Name=""No Spacing""/>
<w:LsdException Locked=""false"" Priority=""60"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Light Shading""/>
<w:LsdException Locked=""false"" Priority=""61"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Light List""/>
<w:LsdException Locked=""false"" Priority=""62"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Light Grid""/>
<w:LsdException Locked=""false"" Priority=""63"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Shading 1""/>
<w:LsdException Locked=""false"" Priority=""64"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Shading 2""/>
<w:LsdException Locked=""false"" Priority=""65"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium List 1""/>
<w:LsdException Locked=""false"" Priority=""66"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium List 2""/>
<w:LsdException Locked=""false"" Priority=""67"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Grid 1""/>
<w:LsdException Locked=""false"" Priority=""68"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Grid 2""/>
<w:LsdException Locked=""false"" Priority=""69"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Grid 3""/>
<w:LsdException Locked=""false"" Priority=""70"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Dark List""/>
<w:LsdException Locked=""false"" Priority=""71"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Colorful Shading""/>
<w:LsdException Locked=""false"" Priority=""72"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Colorful List""/>
<w:LsdException Locked=""false"" Priority=""73"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Colorful Grid""/>
<w:LsdException Locked=""false"" Priority=""60"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Light Shading Accent 1""/>
<w:LsdException Locked=""false"" Priority=""61"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Light List Accent 1""/>
<w:LsdException Locked=""false"" Priority=""62"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Light Grid Accent 1""/>
<w:LsdException Locked=""false"" Priority=""63"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Shading 1 Accent 1""/>
<w:LsdException Locked=""false"" Priority=""64"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Shading 2 Accent 1""/>
<w:LsdException Locked=""false"" Priority=""65"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium List 1 Accent 1""/>
<w:LsdException Locked=""false"" UnhideWhenUsed=""false"" Name=""Revision""/>
<w:LsdException Locked=""false"" Priority=""34"" SemiHidden=""false"" UnhideWhenUsed=""false"" QFormat=""true"" Name=""List Paragraph""/>
<w:LsdException Locked=""false"" Priority=""29"" SemiHidden=""false"" UnhideWhenUsed=""false"" QFormat=""true"" Name=""Quote""/>
<w:LsdException Locked=""false"" Priority=""30"" SemiHidden=""false"" UnhideWhenUsed=""false"" QFormat=""true"" Name=""Intense Quote""/>
<w:LsdException Locked=""false"" Priority=""66"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium List 2 Accent 1""/>
<w:LsdException Locked=""false"" Priority=""67"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Grid 1 Accent 1""/>
<w:LsdException Locked=""false"" Priority=""68"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Grid 2 Accent 1""/>
<w:LsdException Locked=""false"" Priority=""69"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Grid 3 Accent 1""/>
<w:LsdException Locked=""false"" Priority=""70"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Dark List Accent 1""/>
<w:LsdException Locked=""false"" Priority=""71"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Colorful Shading Accent 1""/>
<w:LsdException Locked=""false"" Priority=""72"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Colorful List Accent 1""/>
<w:LsdException Locked=""false"" Priority=""73"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Colorful Grid Accent 1""/>
<w:LsdException Locked=""false"" Priority=""60"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Light Shading Accent 2""/>
<w:LsdException Locked=""false"" Priority=""61"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Light List Accent 2""/>
<w:LsdException Locked=""false"" Priority=""62"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Light Grid Accent 2""/>
<w:LsdException Locked=""false"" Priority=""63"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Shading 1 Accent 2""/>
<w:LsdException Locked=""false"" Priority=""64"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Shading 2 Accent 2""/>
<w:LsdException Locked=""false"" Priority=""65"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium List 1 Accent 2""/>
<w:LsdException Locked=""false"" Priority=""66"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium List 2 Accent 2""/>
<w:LsdException Locked=""false"" Priority=""67"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Grid 1 Accent 2""/>
<w:LsdException Locked=""false"" Priority=""68"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Grid 2 Accent 2""/>
<w:LsdException Locked=""false"" Priority=""69"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Grid 3 Accent 2""/>
<w:LsdException Locked=""false"" Priority=""70"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Dark List Accent 2""/>
<w:LsdException Locked=""false"" Priority=""71"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Colorful Shading Accent 2""/>
<w:LsdException Locked=""false"" Priority=""72"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Colorful List Accent 2""/>
<w:LsdException Locked=""false"" Priority=""73"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Colorful Grid Accent 2""/>
<w:LsdException Locked=""false"" Priority=""60"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Light Shading Accent 3""/>
<w:LsdException Locked=""false"" Priority=""61"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Light List Accent 3""/>
<w:LsdException Locked=""false"" Priority=""62"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Light Grid Accent 3""/>
<w:LsdException Locked=""false"" Priority=""63"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Shading 1 Accent 3""/>
<w:LsdException Locked=""false"" Priority=""64"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Shading 2 Accent 3""/>
<w:LsdException Locked=""false"" Priority=""65"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium List 1 Accent 3""/>
<w:LsdException Locked=""false"" Priority=""66"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium List 2 Accent 3""/>
<w:LsdException Locked=""false"" Priority=""67"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Grid 1 Accent 3""/>
<w:LsdException Locked=""false"" Priority=""68"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Grid 2 Accent 3""/>
<w:LsdException Locked=""false"" Priority=""69"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Grid 3 Accent 3""/>
<w:LsdException Locked=""false"" Priority=""70"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Dark List Accent 3""/>
<w:LsdException Locked=""false"" Priority=""71"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Colorful Shading Accent 3""/>
<w:LsdException Locked=""false"" Priority=""72"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Colorful List Accent 3""/>
<w:LsdException Locked=""false"" Priority=""73"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Colorful Grid Accent 3""/>
<w:LsdException Locked=""false"" Priority=""60"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Light Shading Accent 4""/>
<w:LsdException Locked=""false"" Priority=""61"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Light List Accent 4""/>
<w:LsdException Locked=""false"" Priority=""62"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Light Grid Accent 4""/>
<w:LsdException Locked=""false"" Priority=""63"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Shading 1 Accent 4""/>
<w:LsdException Locked=""false"" Priority=""64"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Shading 2 Accent 4""/>
<w:LsdException Locked=""false"" Priority=""65"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium List 1 Accent 4""/>
<w:LsdException Locked=""false"" Priority=""66"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium List 2 Accent 4""/>
<w:LsdException Locked=""false"" Priority=""67"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Grid 1 Accent 4""/>
<w:LsdException Locked=""false"" Priority=""68"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Grid 2 Accent 4""/>
<w:LsdException Locked=""false"" Priority=""69"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Grid 3 Accent 4""/>
<w:LsdException Locked=""false"" Priority=""70"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Dark List Accent 4""/>
<w:LsdException Locked=""false"" Priority=""71"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Colorful Shading Accent 4""/>
<w:LsdException Locked=""false"" Priority=""72"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Colorful List Accent 4""/>
<w:LsdException Locked=""false"" Priority=""73"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Colorful Grid Accent 4""/>
<w:LsdException Locked=""false"" Priority=""60"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Light Shading Accent 5""/>
<w:LsdException Locked=""false"" Priority=""61"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Light List Accent 5""/>
<w:LsdException Locked=""false"" Priority=""62"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Light Grid Accent 5""/>
<w:LsdException Locked=""false"" Priority=""63"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Shading 1 Accent 5""/>
<w:LsdException Locked=""false"" Priority=""64"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Shading 2 Accent 5""/>
<w:LsdException Locked=""false"" Priority=""65"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium List 1 Accent 5""/>
<w:LsdException Locked=""false"" Priority=""66"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium List 2 Accent 5""/>
<w:LsdException Locked=""false"" Priority=""67"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Grid 1 Accent 5""/>
<w:LsdException Locked=""false"" Priority=""68"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Grid 2 Accent 5""/>
<w:LsdException Locked=""false"" Priority=""69"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Grid 3 Accent 5""/>
<w:LsdException Locked=""false"" Priority=""70"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Dark List Accent 5""/>
<w:LsdException Locked=""false"" Priority=""71"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Colorful Shading Accent 5""/>
<w:LsdException Locked=""false"" Priority=""72"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Colorful List Accent 5""/>
<w:LsdException Locked=""false"" Priority=""73"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Colorful Grid Accent 5""/>
<w:LsdException Locked=""false"" Priority=""60"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Light Shading Accent 6""/>
<w:LsdException Locked=""false"" Priority=""61"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Light List Accent 6""/>
<w:LsdException Locked=""false"" Priority=""62"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Light Grid Accent 6""/>
<w:LsdException Locked=""false"" Priority=""63"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Shading 1 Accent 6""/>
<w:LsdException Locked=""false"" Priority=""64"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Shading 2 Accent 6""/>
<w:LsdException Locked=""false"" Priority=""65"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium List 1 Accent 6""/>
<w:LsdException Locked=""false"" Priority=""66"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium List 2 Accent 6""/>
<w:LsdException Locked=""false"" Priority=""67"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Grid 1 Accent 6""/>
<w:LsdException Locked=""false"" Priority=""68"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Grid 2 Accent 6""/>
<w:LsdException Locked=""false"" Priority=""69"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Medium Grid 3 Accent 6""/>
<w:LsdException Locked=""false"" Priority=""70"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Dark List Accent 6""/>
<w:LsdException Locked=""false"" Priority=""71"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Colorful Shading Accent 6""/>
<w:LsdException Locked=""false"" Priority=""72"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Colorful List Accent 6""/>
<w:LsdException Locked=""false"" Priority=""73"" SemiHidden=""false"" UnhideWhenUsed=""false"" Name=""Colorful Grid Accent 6""/>
<w:LsdException Locked=""false"" Priority=""19"" SemiHidden=""false"" UnhideWhenUsed=""false"" QFormat=""true"" Name=""Subtle Emphasis""/>
<w:LsdException Locked=""false"" Priority=""21"" SemiHidden=""false"" UnhideWhenUsed=""false"" QFormat=""true"" Name=""Intense Emphasis""/>
<w:LsdException Locked=""false"" Priority=""31"" SemiHidden=""false"" UnhideWhenUsed=""false"" QFormat=""true"" Name=""Subtle Reference""/>
<w:LsdException Locked=""false"" Priority=""32"" SemiHidden=""false"" UnhideWhenUsed=""false"" QFormat=""true"" Name=""Intense Reference""/>
<w:LsdException Locked=""false"" Priority=""33"" SemiHidden=""false"" UnhideWhenUsed=""false"" QFormat=""true"" Name=""Book Title""/>
<w:LsdException Locked=""false"" Priority=""37"" Name=""Bibliography""/>
<w:LsdException Locked=""false"" Priority=""39"" QFormat=""true"" Name=""TOC Heading""/>
</w:LatentStyles>
</xml><![endif]--><style><!--
/* Font Definitions */
@font-face
	{font-family:Wingdings;
	panose-1:5 0 0 0 0 0 0 0 0 0;
	mso-font-charset:2;
	mso-generic-font-family:auto;
	mso-font-pitch:variable;
	mso-font-signature:0 268435456 0 0 -2147483648 0;}
@font-face
	{font-family:Wingdings;
	panose-1:5 0 0 0 0 0 0 0 0 0;
	mso-font-charset:2;
	mso-generic-font-family:auto;
	mso-font-pitch:variable;
	mso-font-signature:0 268435456 0 0 -2147483648 0;}
@font-face
	{font-family:Calibri;
	panose-1:2 15 5 2 2 2 4 3 2 4;
	mso-font-charset:0;
	mso-generic-font-family:swiss;
	mso-font-pitch:variable;
	mso-font-signature:-536870145 1073786111 1 0 415 0;}
@font-face
	{font-family:Tahoma;
	panose-1:2 11 6 4 3 5 4 4 2 4;
	mso-font-charset:0;
	mso-generic-font-family:swiss;
	mso-font-pitch:variable;
	mso-font-signature:-520081665 -1073717157 41 0 66047 0;}
/* Style Definitions */
p.MsoNormal, li.MsoNormal, div.MsoNormal
	{mso-style-unhide:no;
	mso-style-qformat:yes;
	mso-style-parent:"""";
	margin:0in;
	margin-bottom:.0001pt;
	mso-pagination:widow-orphan;
	font-size:12.0pt;
	font-family:""Times New Roman"",""serif"";
	mso-fareast-font-family:Calibri;
	mso-fareast-theme-font:minor-latin;}
a:link, span.MsoHyperlink
	{mso-style-noshow:yes;
	mso-style-priority:99;
	color:blue;
	mso-themecolor:hyperlink;
	text-decoration:underline;
	text-underline:single;}
a:visited, span.MsoHyperlinkFollowed
	{mso-style-noshow:yes;
	mso-style-priority:99;
	color:purple;
	mso-themecolor:followedhyperlink;
	text-decoration:underline;
	text-underline:single;}
span.EmailStyle17
	{mso-style-type:personal-reply;
	mso-style-noshow:yes;
	mso-style-unhide:no;
	mso-ansi-font-size:11.0pt;
	mso-bidi-font-size:11.0pt;
	font-family:""Calibri"",""sans-serif"";
	mso-ascii-font-family:Calibri;
	mso-ascii-theme-font:minor-latin;
	mso-fareast-font-family:Calibri;
	mso-fareast-theme-font:minor-latin;
	mso-hansi-font-family:Calibri;
	mso-hansi-theme-font:minor-latin;
	mso-bidi-font-family:""Times New Roman"";
	mso-bidi-theme-font:minor-bidi;
	color:#1F497D;
	mso-themecolor:dark2;}
.MsoChpDefault
	{mso-style-type:export-only;
	mso-default-props:yes;
	font-family:""Calibri"",""sans-serif"";
	mso-ascii-font-family:Calibri;
	mso-ascii-theme-font:minor-latin;
	mso-fareast-font-family:Calibri;
	mso-fareast-theme-font:minor-latin;
	mso-hansi-font-family:Calibri;
	mso-hansi-theme-font:minor-latin;
	mso-bidi-font-family:""Times New Roman"";
	mso-bidi-theme-font:minor-bidi;}
@page WordSection1
	{size:8.5in 11.0in;
	margin:1.0in 1.0in 1.0in 1.0in;
	mso-header-margin:.5in;
	mso-footer-margin:.5in;
	mso-paper-source:0;}
div.WordSection1
	{page:WordSection1;}
/* List Definitions */
@list l0
	{mso-list-id:314572916;
	mso-list-template-ids:430106056;}
@list l0:level1
	{mso-level-number-format:bullet;
	mso-level-text:\F0B7;
	mso-level-tab-stop:.5in;
	mso-level-number-position:left;
	text-indent:-.25in;
	mso-ansi-font-size:10.0pt;
	font-family:Symbol;}
@list l0:level2
	{mso-level-number-format:bullet;
	mso-level-text:o;
	mso-level-tab-stop:1.0in;
	mso-level-number-position:left;
	text-indent:-.25in;
	mso-ansi-font-size:10.0pt;
	font-family:""Courier New"";
	mso-bidi-font-family:""Times New Roman"";}
@list l0:level3
	{mso-level-number-format:bullet;
	mso-level-text:\F0A7;
	mso-level-tab-stop:1.5in;
	mso-level-number-position:left;
	text-indent:-.25in;
	mso-ansi-font-size:10.0pt;
	font-family:Wingdings;}
@list l0:level4
	{mso-level-number-format:bullet;
	mso-level-text:\F0A7;
	mso-level-tab-stop:2.0in;
	mso-level-number-position:left;
	text-indent:-.25in;
	mso-ansi-font-size:10.0pt;
	font-family:Wingdings;}
@list l0:level5
	{mso-level-number-format:bullet;
	mso-level-text:\F0A7;
	mso-level-tab-stop:2.5in;
	mso-level-number-position:left;
	text-indent:-.25in;
	mso-ansi-font-size:10.0pt;
	font-family:Wingdings;}
@list l0:level6
	{mso-level-number-format:bullet;
	mso-level-text:\F0A7;
	mso-level-tab-stop:3.0in;
	mso-level-number-position:left;
	text-indent:-.25in;
	mso-ansi-font-size:10.0pt;
	font-family:Wingdings;}
@list l0:level7
	{mso-level-number-format:bullet;
	mso-level-text:\F0A7;
	mso-level-tab-stop:3.5in;
	mso-level-number-position:left;
	text-indent:-.25in;
	mso-ansi-font-size:10.0pt;
	font-family:Wingdings;}
@list l0:level8
	{mso-level-number-format:bullet;
	mso-level-text:\F0A7;
	mso-level-tab-stop:4.0in;
	mso-level-number-position:left;
	text-indent:-.25in;
	mso-ansi-font-size:10.0pt;
	font-family:Wingdings;}
@list l0:level9
	{mso-level-number-format:bullet;
	mso-level-text:\F0A7;
	mso-level-tab-stop:4.5in;
	mso-level-number-position:left;
	text-indent:-.25in;
	mso-ansi-font-size:10.0pt;
	font-family:Wingdings;}
ol
	{margin-bottom:0in;}
ul
	{margin-bottom:0in;}
--></style><!--[if gte mso 10]><style>/* Style Definitions */
table.MsoNormalTable
	{mso-style-name:""Table Normal"";
	mso-tstyle-rowband-size:0;
	mso-tstyle-colband-size:0;
	mso-style-noshow:yes;
	mso-style-priority:99;
	mso-style-parent:"""";
	mso-padding-alt:0in 5.4pt 0in 5.4pt;
	mso-para-margin:0in;
	mso-para-margin-bottom:.0001pt;
	mso-pagination:widow-orphan;
	font-size:11.0pt;
	font-family:""Calibri"",""sans-serif"";
	mso-ascii-font-family:Calibri;
	mso-ascii-theme-font:minor-latin;
	mso-hansi-font-family:Calibri;
	mso-hansi-theme-font:minor-latin;}
</style><![endif]--><!--[if gte mso 9]><xml>
<o:shapedefaults v:ext=""edit"" spidmax=""1026"" />
</xml><![endif]--><!--[if gte mso 9]><xml>
<o:shapelayout v:ext=""edit"">
<o:idmap v:ext=""edit"" data=""1"" />
</o:shapelayout></xml><![endif]--></head>";

    }
}
