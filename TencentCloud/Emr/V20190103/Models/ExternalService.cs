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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExternalService : AbstractModel
    {
        
        /// <summary>
        /// Shared component type, which can be EMR or CUSTOM
        /// </summary>
        [JsonProperty("ShareType")]
        public string ShareType{ get; set; }

        /// <summary>
        /// Custom parameters
        /// </summary>
        [JsonProperty("CustomServiceDefineList")]
        public CustomServiceDefine[] CustomServiceDefineList{ get; set; }

        /// <summary>
        /// Shared component name
        /// </summary>
        [JsonProperty("Service")]
        public string Service{ get; set; }

        /// <summary>
        /// Shared component cluster
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ShareType", this.ShareType);
            this.SetParamArrayObj(map, prefix + "CustomServiceDefineList.", this.CustomServiceDefineList);
            this.SetParamSimple(map, prefix + "Service", this.Service);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
        }
    }
}

