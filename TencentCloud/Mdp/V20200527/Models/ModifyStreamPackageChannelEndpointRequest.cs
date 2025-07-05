/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Mdp.V20200527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyStreamPackageChannelEndpointRequest : AbstractModel
    {
        
        /// <summary>
        /// Channel ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Channel endpoint URL
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// New endpoint name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// New channel authentication information
        /// </summary>
        [JsonProperty("AuthInfo")]
        public EndpointAuthInfo AuthInfo{ get; set; }

        /// <summary>
        /// Endpoint protocol.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Whether to turn on the time shift function, true: on, false: off, the default is off.
        /// </summary>
        [JsonProperty("TimeShiftEnable")]
        public bool? TimeShiftEnable{ get; set; }

        /// <summary>
        /// The number of days in the time shift window, up to 30 days. Valid when TimeShiftEnable is turned on.
        /// </summary>
        [JsonProperty("TimeShiftDuration")]
        public ulong? TimeShiftDuration{ get; set; }

        /// <summary>
        /// Advertising insertion function switch.
        /// </summary>
        [JsonProperty("SSAIEnable")]
        public bool? SSAIEnable{ get; set; }

        /// <summary>
        /// Ad insertion function configuration information. Valid when SSAIEnable is turned on.
        /// </summary>
        [JsonProperty("SSAIInfo")]
        public SSAIConf SSAIInfo{ get; set; }

        /// <summary>
        /// The customer-defined url parameter is inserted into the subscript at the specified position of the Endpoint url. 
        /// Calculation starts from the first '/' in the url path, and the subscript starts from 0, the optional range of the subscript is: [0,3].
        /// </summary>
        [JsonProperty("CustomUrlParamIndex")]
        public ulong? CustomUrlParamIndex{ get; set; }

        /// <summary>
        /// Customer-defined url parameters are inserted into the specified position of the Endpoint url based on the CustomUrlParamIndex.
        /// The parameters can only contain digits, letters, underscores (_), and hyphens (-), with a length of 1 to 64 chars.
        /// </summary>
        [JsonProperty("CustomUrlParam")]
        public string CustomUrlParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "AuthInfo.", this.AuthInfo);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "TimeShiftEnable", this.TimeShiftEnable);
            this.SetParamSimple(map, prefix + "TimeShiftDuration", this.TimeShiftDuration);
            this.SetParamSimple(map, prefix + "SSAIEnable", this.SSAIEnable);
            this.SetParamObj(map, prefix + "SSAIInfo.", this.SSAIInfo);
            this.SetParamSimple(map, prefix + "CustomUrlParamIndex", this.CustomUrlParamIndex);
            this.SetParamSimple(map, prefix + "CustomUrlParam", this.CustomUrlParam);
        }
    }
}

