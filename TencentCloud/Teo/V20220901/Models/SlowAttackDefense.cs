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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SlowAttackDefense : AbstractModel
    {
        
        /// <summary>
        /// Whether slow attack protection is enabled. Valid values: <li>on: enabled;</li><li>off: disabled.</li>
        /// </summary>
        [JsonProperty("Enabled")]
        public string Enabled{ get; set; }

        /// <summary>
        /// Rule ID of slow attack protection, returned only as an output parameter.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Handling method for slow attack protection. This field is required when Enabled is on. Supported values for SecurityAction Name: <li>Monitor: observe;</li><li>Deny: block;</li>
        /// </summary>
        [JsonProperty("Action")]
        public SecurityAction Action{ get; set; }

        /// <summary>
        /// Specific configuration of the minimum body transfer rate threshold. Required when Enabled is on.
        /// </summary>
        [JsonProperty("MinimalRequestBodyTransferRate")]
        public MinimalRequestBodyTransferRate MinimalRequestBodyTransferRate{ get; set; }

        /// <summary>
        /// Specific configuration of the body transfer timeout duration. Required if Enabled is on.
        /// </summary>
        [JsonProperty("RequestBodyTransferTimeout")]
        public RequestBodyTransferTimeout RequestBodyTransferTimeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamObj(map, prefix + "Action.", this.Action);
            this.SetParamObj(map, prefix + "MinimalRequestBodyTransferRate.", this.MinimalRequestBodyTransferRate);
            this.SetParamObj(map, prefix + "RequestBodyTransferTimeout.", this.RequestBodyTransferTimeout);
        }
    }
}

