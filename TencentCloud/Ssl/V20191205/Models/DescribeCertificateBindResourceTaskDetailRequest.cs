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

    public class DescribeCertificateBindResourceTaskDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Task ID. Query the result of binding cloud resources based on the task ID obtained from CreateCertificateBindResourceSyncTask.</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>Number of items per page, default 10, maximum value 100; total pages is the total number of instances in the resource region, that is, page 1 will pull the number of instances under each Tencent Cloud resource region up to the Limit</p>
        /// </summary>
        [JsonProperty("Limit")]
        public string Limit{ get; set; }

        /// <summary>
        /// <p>Offset, defaults to 0</p>
        /// </summary>
        [JsonProperty("Offset")]
        public string Offset{ get; set; }

        /// <summary>
        /// <p>Query result details of the resource type. Query all if not specified. Supported values: - clb- cdn- ddos- live- vod- waf- apigateway- teo- tke- cos- tse- tcb</p>
        /// </summary>
        [JsonProperty("ResourceTypes")]
        public string[] ResourceTypes{ get; set; }

        /// <summary>
        /// <p>Query the data of region list. clb, tke, waf, API Gateway, tcb, cos, and tse support query region. Other resource types are unsupported.</p>
        /// </summary>
        [JsonProperty("Regions")]
        public string[] Regions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArraySimple(map, prefix + "ResourceTypes.", this.ResourceTypes);
            this.SetParamArraySimple(map, prefix + "Regions.", this.Regions);
        }
    }
}

