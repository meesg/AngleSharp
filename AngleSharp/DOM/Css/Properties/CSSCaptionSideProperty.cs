﻿namespace AngleSharp.DOM.Css.Properties
{
    using System;

    /// <summary>
    /// Information can be found on MDN:
    /// https://developer.mozilla.org/en-US/docs/Web/CSS/caption-side
    /// </summary>
    sealed class CSSCaptionSideProperty : CSSProperty, ICssCaptionSideProperty
    {
        #region Fields

        Boolean _top;

        #endregion

        #region ctor

        internal CSSCaptionSideProperty()
            : base(PropertyNames.CaptionSide)
        {
            _top = true;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets if the caption box will be above the table.
        /// Otherwise the caption box will be below the table.
        /// </summary>
        public Boolean IsOnTop
        {
            get { return _top; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Determines if the given value represents a valid state of this property.
        /// </summary>
        /// <param name="value">The state that should be used.</param>
        /// <returns>True if the state is valid, otherwise false.</returns>
        protected override Boolean IsValid(CSSValue value)
        {
            if (value.Is(Keywords.Top))
                _top = true;
            else if (value.Is(Keywords.Bottom))
                _top = false;
            else if (value != CSSValue.Inherit)
                return false;

            return true;
        }

        #endregion
    }
}
