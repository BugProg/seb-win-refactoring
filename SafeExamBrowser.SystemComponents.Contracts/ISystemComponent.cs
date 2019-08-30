﻿/*
 * Copyright (c) 2019 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

namespace SafeExamBrowser.SystemComponents.Contracts
{
	/// <summary>
	/// Defines the functionality of a system component (e.g. the power supply). Each system component can get multiple <see cref="ISystemControl"/>
	/// assigned, which in turn allow the user to interact with or get information about the underlying system component.
	/// </summary>
	public interface ISystemComponent// TODO <TControl> where TControl : ISystemControl
	{
		/// <summary>
		/// Initializes the resources and operations of the component.
		/// </summary>
		void Initialize();

		// TODO
		///// <summary>
		///// Registers a system control which will be loaded into shell.
		///// </summary>
		//void Register(TControl control);

		/// <summary>
		/// Instructs the component to stop any running operations and releases all used resources.
		/// </summary>
		void Terminate();
	}
}