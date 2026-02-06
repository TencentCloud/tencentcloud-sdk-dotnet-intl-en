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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyInstanceParamsRequest : AbstractModel
    {
        
        /// <summary>
        /// Specifies the instance ID. For example, cmgo-p8vn****. Log in to the [TencentDB for MongoDB console](https://console.cloud.tencent.com/mongodb), and copy the instance ID from the instance list.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Specifies the parameter name and value to be modified. For details about the currently supported parameter names and the corresponding valid values, see [DescribeInstanceParams](https://www.tencentcloud.com/document/product/240/65903?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("InstanceParams")]
        public ModifyMongoDBParamType[] InstanceParams{ get; set; }

        /// <summary>
        /// Operation type. Valid values:
        /// - IMMEDIATELY: immediate adjustment.
        /// - DELAY: delayed adjustment. It is an optional field. The default value is immediate adjustment if this parameter is left unspecified.
        /// </summary>
        [JsonProperty("ModifyType")]
        public string ModifyType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArrayObj(map, prefix + "InstanceParams.", this.InstanceParams);
            this.SetParamSimple(map, prefix + "ModifyType", this.ModifyType);
        }
    }
}

