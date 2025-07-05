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

namespace TencentCloud.Vm.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StorageInfo : AbstractModel
    {
        
        /// <summary>
        /// This field indicates the file access type. Valid values: **URL** (resource link), **COS** (Tencent Cloud COS). It should correspond to the access type passed in and can be used for strict verification and quick identification of the access address. If you don't pass in this parameter, the default value will be `URL`, and the system will automatically determine the access address type.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// This field indicates the link address for file access in standard URL format.<br>Note: when `Type` is `URL`, this field will not be empty. You must pass in either this parameter or the `BucketInfo` parameter.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// This field indicates the Tencent Cloud bucket information for file access.<br>Note: when `Type` is `COS`, this field will not be empty. You must pass in either this parameter or the `Url` parameter.
        /// </summary>
        [JsonProperty("BucketInfo")]
        public BucketInfo BucketInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamObj(map, prefix + "BucketInfo.", this.BucketInfo);
        }
    }
}

