﻿/*
 * Copyright (c) 2018 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using System;
using System.ServiceModel;
using SafeExamBrowser.Contracts.Communication.Messages;
using SafeExamBrowser.Contracts.Communication.Responses;
using SafeExamBrowser.Contracts.Configuration;

namespace SafeExamBrowser.Contracts.Communication
{
	[ServiceContract(SessionMode = SessionMode.Required)]
	[ServiceKnownType(typeof(SimpleMessage))]
	[ServiceKnownType(typeof(AuthenticationResponse))]
	[ServiceKnownType(typeof(ConfigurationResponse))]
	[ServiceKnownType(typeof(ClientConfiguration))]
	public interface ICommunication
	{
		/// <summary>
		/// Initiates a connection and must thus be called before any other opertion. Where applicable, an authentication token should be
		/// specified. Returns a response indicating whether the connection request was successful or not.
		/// </summary>
		[OperationContract(IsInitiating = true)]
		ConnectionResponse Connect(Guid? token = null);

		/// <summary>
		/// Closes a connection. Returns a response indicating whether the disconnection request was successful or not.
		/// </summary>
		[OperationContract(IsInitiating = false, IsTerminating = true)]
		DisconnectionResponse Disconnect(DisconnectionMessage message);

		/// <summary>
		/// Sends a message, optionally returning a response. If no response is expected, <c>null</c> will be returned.
		/// </summary>
		[OperationContract(IsInitiating = false)]
		Response Send(Message message);
	}
}
