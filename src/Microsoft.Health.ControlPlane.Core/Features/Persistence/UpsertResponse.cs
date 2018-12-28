﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;

namespace Microsoft.Health.ControlPlane.Core.Features.Persistence
{
    public class UpsertResponse<T>
        where T : class
    {
        public UpsertResponse(T controlPlaneResource, UpsertOutcomeType outcomeType, string eTag)
        {
            if (controlPlaneResource == null)
            {
                throw new ArgumentNullException(nameof(controlPlaneResource));
            }

            ControlPlaneResource = controlPlaneResource;
            OutcomeType = outcomeType;
            ETag = eTag;
        }

        public T ControlPlaneResource { get; }

        public UpsertOutcomeType OutcomeType { get; }

        public string ETag { get; }
    }
}