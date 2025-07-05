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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBucketListRequest : AbstractModel
    {
        
        /// <summary>
        /// Data source service provider. Valid values: `COS` (Tencent Cloud COS), `OSS` (Alibaba Cloud OSS), and `OBS` (Huawei Cloud OBS).
        /// </summary>
        [JsonProperty("SrcService")]
        public string SrcService{ get; set; }

        /// <summary>
        /// SecretId of the data source account
        /// </summary>
        [JsonProperty("SrcSecretId")]
        public string SrcSecretId{ get; set; }

        /// <summary>
        /// SecretKey of the data source account
        /// </summary>
        [JsonProperty("SrcSecretKey")]
        public string SrcSecretKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SrcService", this.SrcService);
            this.SetParamSimple(map, prefix + "SrcSecretId", this.SrcSecretId);
            this.SetParamSimple(map, prefix + "SrcSecretKey", this.SrcSecretKey);
        }
    }
}

