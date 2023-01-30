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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeValueAddedSrvInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// Number of unlicensed repository images
        /// </summary>
        [JsonProperty("RegistryImageCnt")]
        public ulong? RegistryImageCnt{ get; set; }

        /// <summary>
        /// Number of unlicensed local images
        /// </summary>
        [JsonProperty("LocalImageCnt")]
        public ulong? LocalImageCnt{ get; set; }

        /// <summary>
        /// Number of unused image security scan licenses
        /// </summary>
        [JsonProperty("UnusedAuthorizedCnt")]
        public ulong? UnusedAuthorizedCnt{ get; set; }

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
            this.SetParamSimple(map, prefix + "RegistryImageCnt", this.RegistryImageCnt);
            this.SetParamSimple(map, prefix + "LocalImageCnt", this.LocalImageCnt);
            this.SetParamSimple(map, prefix + "UnusedAuthorizedCnt", this.UnusedAuthorizedCnt);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

