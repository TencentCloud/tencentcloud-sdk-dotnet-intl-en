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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeHostUpdateRecordDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// Deployment record id, which is the record id returned by calling the UpdateCertificateInstance api, or the record id returned by calling the UpdateCertificateRecordRollback rollback api.
        /// </summary>
        [JsonProperty("DeployRecordId")]
        public string DeployRecordId{ get; set; }

        /// <summary>
        /// Number of items per page. the default is 10. the maximum value is 200.
        /// </summary>
        [JsonProperty("Limit")]
        public string Limit{ get; set; }

        /// <summary>
        /// Pagination offset, starting from 0. default is 0.
        /// </summary>
        [JsonProperty("Offset")]
        public string Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeployRecordId", this.DeployRecordId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

