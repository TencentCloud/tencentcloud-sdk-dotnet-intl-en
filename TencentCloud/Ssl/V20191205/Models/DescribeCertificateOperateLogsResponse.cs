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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCertificateOperateLogsResponse : AbstractModel
    {
        
        /// <summary>
        /// Total number of logs that meet query conditions
        /// </summary>
        [JsonProperty("AllTotal")]
        public ulong? AllTotal{ get; set; }

        /// <summary>
        /// Number of logs returned for this request
        /// </summary>
        [JsonProperty("TotalCount")]
        public ulong? TotalCount{ get; set; }

        /// <summary>
        /// Certificate operation log list
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OperateLogs")]
        public OperationLog[] OperateLogs{ get; set; }

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
            this.SetParamSimple(map, prefix + "AllTotal", this.AllTotal);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamArrayObj(map, prefix + "OperateLogs.", this.OperateLogs);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

