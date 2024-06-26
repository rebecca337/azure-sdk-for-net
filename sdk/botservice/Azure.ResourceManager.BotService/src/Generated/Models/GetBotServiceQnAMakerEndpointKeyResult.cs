// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> Schema for EndpointKeys generate/refresh operations. </summary>
    public partial class GetBotServiceQnAMakerEndpointKeyResult
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="GetBotServiceQnAMakerEndpointKeyResult"/>. </summary>
        internal GetBotServiceQnAMakerEndpointKeyResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GetBotServiceQnAMakerEndpointKeyResult"/>. </summary>
        /// <param name="primaryEndpointKey"> Primary Access Key. </param>
        /// <param name="secondaryEndpointKey"> Secondary Access Key. </param>
        /// <param name="installedVersion"> Current version of runtime. </param>
        /// <param name="lastStableVersion"> Latest version of runtime. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GetBotServiceQnAMakerEndpointKeyResult(string primaryEndpointKey, string secondaryEndpointKey, string installedVersion, string lastStableVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PrimaryEndpointKey = primaryEndpointKey;
            SecondaryEndpointKey = secondaryEndpointKey;
            InstalledVersion = installedVersion;
            LastStableVersion = lastStableVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Primary Access Key. </summary>
        public string PrimaryEndpointKey { get; }
        /// <summary> Secondary Access Key. </summary>
        public string SecondaryEndpointKey { get; }
        /// <summary> Current version of runtime. </summary>
        public string InstalledVersion { get; }
        /// <summary> Latest version of runtime. </summary>
        public string LastStableVersion { get; }
    }
}
