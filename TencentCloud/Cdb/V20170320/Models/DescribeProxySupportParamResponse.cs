/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeProxySupportParamResponse : AbstractModel
    {
        
        /// <summary>
        /// The supported maximum proxy version Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProxyVersion")]
        public string ProxyVersion{ get; set; }

        /// <summary>
        /// Whether to support the connection pool Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SupportPool")]
        public bool? SupportPool{ get; set; }

        /// <summary>
        /// Minimum connections in the connection pool Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PoolMin")]
        public ulong? PoolMin{ get; set; }

        /// <summary>
        /// Maximum connections in the connection pool Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PoolMax")]
        public ulong? PoolMax{ get; set; }

        /// <summary>
        /// Whether to support transaction splitting Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SupportTransSplit")]
        public bool? SupportTransSplit{ get; set; }

        /// <summary>
        /// Minimum proxy version supporting connection pool Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SupportPoolMinVersion")]
        public string SupportPoolMinVersion{ get; set; }

        /// <summary>
        /// Minimum proxy version supporting transaction splitting Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SupportTransSplitMinVersion")]
        public string SupportTransSplitMinVersion{ get; set; }

        /// <summary>
        /// Whether read-only mode is supported Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SupportReadOnly")]
        public bool? SupportReadOnly{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProxyVersion", this.ProxyVersion);
            this.SetParamSimple(map, prefix + "SupportPool", this.SupportPool);
            this.SetParamSimple(map, prefix + "PoolMin", this.PoolMin);
            this.SetParamSimple(map, prefix + "PoolMax", this.PoolMax);
            this.SetParamSimple(map, prefix + "SupportTransSplit", this.SupportTransSplit);
            this.SetParamSimple(map, prefix + "SupportPoolMinVersion", this.SupportPoolMinVersion);
            this.SetParamSimple(map, prefix + "SupportTransSplitMinVersion", this.SupportTransSplitMinVersion);
            this.SetParamSimple(map, prefix + "SupportReadOnly", this.SupportReadOnly);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

