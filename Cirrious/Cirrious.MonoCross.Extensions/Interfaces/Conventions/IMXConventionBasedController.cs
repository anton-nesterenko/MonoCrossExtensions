﻿#region Copyright

// ----------------------------------------------------------------------
// // <copyright file="IMXConventionBasedController.cs" company="Cirrious">
// //     (c) Copyright Cirrious. http://www.cirrious.com
// //     This source is subject to the Microsoft Public License (Ms-PL)
// //     Please see license.txt on http://opensource.org/licenses/ms-pl.html
// //     All other rights reserved.
// // </copyright>
// // 
// // Author - Stuart Lodge, Cirrious. http://www.cirrious.com
// // ------------------------------------------------------------------------

#endregion

#region using

using MonoCross.Navigation;

#endregion

namespace Cirrious.MonoCross.Extensions.Interfaces.Conventions
{
    public interface IMXConventionBasedController : IMXController
    {
        IMXControllerConvention Convention { get; }
    }
}