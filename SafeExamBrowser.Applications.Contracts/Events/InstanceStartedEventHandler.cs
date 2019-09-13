﻿/*
 * Copyright (c) 2019 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

namespace SafeExamBrowser.Applications.Contracts.Events
{
	/// <summary>
	/// Event handler used to inform about the existence of a new <see cref="IApplicationInstance"/>.
	/// </summary>
	public delegate void InstanceStartedEventHandler(IApplicationInstance instance);
}