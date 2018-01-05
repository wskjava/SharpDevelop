﻿// Copyright (c) 2014 AlphaSierraPapa for the SharpDevelop Team
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this
// software and associated documentation files (the "Software"), to deal in the Software
// without restriction, including without limitation the rights to use, copy, modify, merge,
// publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons
// to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or
// substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
// PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
// FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
// OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.

using System;
using ICSharpCode.NRefactory.TypeSystem;
using NUnit.Framework;
using XmlEditor.Tests.Utils;

namespace XmlEditor.Tests.Folding
{
	[TestFixture]
	public class ShowElementAttributesInFoldTestFixture
	{
		XmlFoldParserHelper helper;
		
		string xml =
			"<root a=\"1st\" b=\"2nd\" c='3rd'>\r\n" +
			"</root>";
		
		[Test]
		public void GetFolds_ShowAttributesIsTrue_FoldNameIsElementNameWithAttributes()
		{
			GetFoldsWhenShowAttributesSetToTrue();
			string name = helper.GetFirstFoldName();
			Assert.AreEqual("<root a=\"1st\" b=\"2nd\" c='3rd'>", name);
		}

		[Test]
		public void GetFolds_ShowAttributesIsFalse_FoldNameIsElementNameOnly()
		{
			GetFoldsWhenShowAttributesSetToFalse();
			string name = helper.GetFirstFoldName();
			Assert.AreEqual("<root>", name);
		}
		
		[Test]
		public void GetFolds_ShowAttributesSetToTrue_FirstFoldRegionContainsRootElement()
		{
			GetFoldsWhenShowAttributesSetToTrue();
			
			DomRegion region = helper.GetFirstFoldRegion();

			int beginLine = 1;
			int beginColumn = 1;
			int endLine = 2;
			int endColumn = 8;
			DomRegion expectedRegion = new DomRegion(beginLine, beginColumn, endLine, endColumn);
			
			Assert.AreEqual(expectedRegion, region);
		}
		
		void GetFoldsWhenShowAttributesSetToTrue()
		{
			helper = new XmlFoldParserHelper();
			helper.Options.ShowAttributesWhenFolded = true;
			GetFolds();
		}

		void GetFolds()
		{
			helper.CreateParser();
			helper.GetFolds(xml);
		}

		void GetFoldsWhenShowAttributesSetToFalse()
		{
			helper = new XmlFoldParserHelper();
			helper.Options.ShowAttributesWhenFolded = false;
			GetFolds();
		}
	}
}
