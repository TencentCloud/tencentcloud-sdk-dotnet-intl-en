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

    public class DescribeCertificateBindResourceTaskDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// Task id, which can be used to query the result of binding cloud resources according to the task id obtained from createcertificatebindresourcesynctask.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// The number of cloud resources displayed on each page. The default value is 10, and the maximum value is 100.
        /// </summary>
        [JsonProperty("Limit")]
        public string Limit{ get; set; }

        /// <summary>
        /// Current offset, default is 0.
        /// </summary>
        [JsonProperty("Offset")]
        public string Offset{ get; set; }

        /// <summary>
        /// Result detail of queried resource type. if not provided, all will be queried. valid values include:.
        /// - clb.
        /// - cdn.
        /// - ddos.
        /// - live.
        /// - vod.
        /// - waf.
        /// - apigateway.
        /// - teo.
        /// - tke.
        /// - cos.
        /// - tse.
        /// - tcb.
        /// </summary>
        [JsonProperty("ResourceTypes")]
        public string[] ResourceTypes{ get; set; }

        /// <summary>
        /// Data of querying region list. clb, tke, waf, api gateway, tcb, cos, and tse support region query, while other resource types do not support.
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

