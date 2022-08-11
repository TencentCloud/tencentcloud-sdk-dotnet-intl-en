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

namespace TencentCloud.Eb.V20210416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TargetDescription : AbstractModel
    {
        
        /// <summary>
        /// Six-Segment QCS resource description. For more information, see [Resource Description Method](https://intl.cloud.tencent.com/document/product/598/10606?from_cn_redirect=1)
        /// </summary>
        [JsonProperty("ResourceDescription")]
        public string ResourceDescription{ get; set; }

        /// <summary>
        /// SCF parameter
        /// </summary>
        [JsonProperty("SCFParams")]
        public SCFParams SCFParams{ get; set; }

        /// <summary>
        /// CKafka parameters
        /// </summary>
        [JsonProperty("CkafkaTargetParams")]
        public CkafkaTargetParams CkafkaTargetParams{ get; set; }

        /// <summary>
        /// ElasticSearch parameters
        /// </summary>
        [JsonProperty("ESTargetParams")]
        public ESTargetParams ESTargetParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceDescription", this.ResourceDescription);
            this.SetParamObj(map, prefix + "SCFParams.", this.SCFParams);
            this.SetParamObj(map, prefix + "CkafkaTargetParams.", this.CkafkaTargetParams);
            this.SetParamObj(map, prefix + "ESTargetParams.", this.ESTargetParams);
        }
    }
}

