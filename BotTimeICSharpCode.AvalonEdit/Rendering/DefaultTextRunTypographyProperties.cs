﻿// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;
using System.Windows;
using System.Windows.Media.TextFormatting;

namespace BotTimeICSharpCode.AvalonEdit.Rendering
{
	/// <summary>
	/// Default implementation for TextRunTypographyProperties.
	/// </summary>
	public class DefaultTextRunTypographyProperties : TextRunTypographyProperties
	{
		/// <inheritdoc/>
		public override FontVariants Variants {
			get { return FontVariants.Normal; }
		}
		
		/// <inheritdoc/>
		public override bool StylisticSet1 { get { return false; } }
		/// <inheritdoc/>
		public override bool StylisticSet2 { get { return false; } }
		/// <inheritdoc/>
		public override bool StylisticSet3 { get { return false; } }
		/// <inheritdoc/>
		public override bool StylisticSet4 { get { return false; } }
		/// <inheritdoc/>
		public override bool StylisticSet5 { get { return false; } }
		/// <inheritdoc/>
		public override bool StylisticSet6 { get { return false; } }
		/// <inheritdoc/>
		public override bool StylisticSet7 { get { return false; } }
		/// <inheritdoc/>
		public override bool StylisticSet8 { get { return false; } }
		/// <inheritdoc/>
		public override bool StylisticSet9 { get { return false; } }
		/// <inheritdoc/>
		public override bool StylisticSet10 { get { return false; } }
		/// <inheritdoc/>
		public override bool StylisticSet11 { get { return false; } }
		/// <inheritdoc/>
		public override bool StylisticSet12 { get { return false; } }
		/// <inheritdoc/>
		public override bool StylisticSet13 { get { return false; } }
		/// <inheritdoc/>
		public override bool StylisticSet14 { get { return false; } }
		/// <inheritdoc/>
		public override bool StylisticSet15 { get { return false; } }
		/// <inheritdoc/>
		public override bool StylisticSet16 { get { return false; } }
		/// <inheritdoc/>
		public override bool StylisticSet17 { get { return false; } }
		/// <inheritdoc/>
		public override bool StylisticSet18 { get { return false; } }
		/// <inheritdoc/>
		public override bool StylisticSet19 { get { return false; } }
		/// <inheritdoc/>
		public override bool StylisticSet20 { get { return false; } }
		
		/// <inheritdoc/>
		public override int StylisticAlternates {
			get { return 0; }
		}
		
		/// <inheritdoc/>
		public override int StandardSwashes {
			get { return 0; }
		}
		
		/// <inheritdoc/>
		public override bool StandardLigatures {
			get { return true; }
		}
		
		/// <inheritdoc/>
		public override bool SlashedZero {
			get { return false; }
		}
		
		/// <inheritdoc/>
		public override FontNumeralStyle NumeralStyle {
			get { return FontNumeralStyle.Normal; }
		}
		
		/// <inheritdoc/>
		public override FontNumeralAlignment NumeralAlignment {
			get { return FontNumeralAlignment.Normal; }
		}
		
		/// <inheritdoc/>
		public override bool MathematicalGreek {
			get { return false; }
		}
		
		/// <inheritdoc/>
		public override bool Kerning {
			get { return true; }
		}
		
		/// <inheritdoc/>
		public override bool HistoricalLigatures {
			get { return false; }
		}
		
		/// <inheritdoc/>
		public override bool HistoricalForms {
			get { return false; }
		}
		
		/// <inheritdoc/>
		public override FontFraction Fraction {
			get { return FontFraction.Normal; }
		}
		
		/// <inheritdoc/>
		public override FontEastAsianWidths EastAsianWidths {
			get { return FontEastAsianWidths.Normal; }
		}
		
		/// <inheritdoc/>
		public override FontEastAsianLanguage EastAsianLanguage {
			get { return FontEastAsianLanguage.Normal; }
		}
		
		/// <inheritdoc/>
		public override bool EastAsianExpertForms {
			get { return false; }
		}
		
		/// <inheritdoc/>
		public override bool DiscretionaryLigatures {
			get { return false; }
		}
		
		/// <inheritdoc/>
		public override int ContextualSwashes {
			get { return 0; }
		}
		
		/// <inheritdoc/>
		public override bool ContextualLigatures {
			get { return true; }
		}
		
		/// <inheritdoc/>
		public override bool ContextualAlternates {
			get { return true; }
		}
		
		/// <inheritdoc/>
		public override bool CaseSensitiveForms {
			get { return false; }
		}
		
		/// <inheritdoc/>
		public override bool CapitalSpacing {
			get { return false; }
		}
		
		/// <inheritdoc/>
		public override FontCapitals Capitals {
			get { return FontCapitals.Normal; }
		}
		
		/// <inheritdoc/>
		public override int AnnotationAlternates {
			get { return 0; }
		}
	}
}
