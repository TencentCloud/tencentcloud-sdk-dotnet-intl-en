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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TargetGroupInstance : AbstractModel
    {
        
        /// <summary>
        /// Private IP of target group instance
        /// </summary>
        [JsonProperty("BindIP")]
        public string BindIP{ get; set; }

        /// <summary>
        /// Port of target group instance. this field is not supported for full listen target groups.
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// Weight of a target group instance
        /// Specifies that the Weight must be configured for a v2 target group. when calling the CreateTargetGroup API for target group creation, this parameter is used in combination with the Weight parameter in the create api, and one of them is required.
        /// Valid values: 0-100.
        /// </summary>
        [JsonProperty("Weight")]
        public ulong? Weight{ get; set; }

        /// <summary>
        /// The new port of the target group instance. this field is not supported for full listen target groups.
        /// </summary>
        [JsonProperty("NewPort")]
        public ulong? NewPort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BindIP", this.BindIP);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "NewPort", this.NewPort);
        }
    }
}

