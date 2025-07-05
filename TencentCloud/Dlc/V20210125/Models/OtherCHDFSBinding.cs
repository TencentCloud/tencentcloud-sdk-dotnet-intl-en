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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OtherCHDFSBinding : AbstractModel
    {
        
        /// <summary>
        /// Product name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// User name (a discarded field)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SuperUser")]
        public string[] SuperUser{ get; set; }

        /// <summary>
        /// VPC configuration information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VpcInfo")]
        public CHDFSProductVpcInfo[] VpcInfo{ get; set; }

        /// <summary>
        /// Whether to bind the bucket (a discarded field)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsBind")]
        public bool? IsBind{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamArraySimple(map, prefix + "SuperUser.", this.SuperUser);
            this.SetParamArrayObj(map, prefix + "VpcInfo.", this.VpcInfo);
            this.SetParamSimple(map, prefix + "IsBind", this.IsBind);
        }
    }
}

