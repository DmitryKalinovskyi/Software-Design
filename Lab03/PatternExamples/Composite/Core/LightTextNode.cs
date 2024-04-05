﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Core
{
    public class LightTextNode: LightNode
    {
        public string Text { get; set; }

        public LightTextNode()
        {
            Text = string.Empty;
        }

        public LightTextNode(string text)
        {
            Text = text;
        }

        /// Methods below are used in recursive HTML generating. For leaf LigthTextNode it may looks empty but it's enough.

        public override string GetInnerHTML()
        {
            // nothing inside text node.
            return "";
        }

        public override string GetOuterHTML()
        {
            return Text;
        }

        public override IEnumerable<string> GetLazyInnerHTML()
        {
            // nothing inside text node.
            yield break;
        }

        public override IEnumerable<string> GetLazyOuterHTML()
        {
            yield return Text;
        }
    }
}
