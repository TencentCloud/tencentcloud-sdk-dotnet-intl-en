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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConfigureSubscribeJobRequest : AbstractModel
    {
        
        /// <summary>
        /// Data subscription instance ID
        /// </summary>
        [JsonProperty("SubscribeId")]
        public string SubscribeId{ get; set; }

        /// <summary>
        /// Data subscription type. Valid values for non-mongo DatabaseType: all (full instance update); dml (data update); ddl (structure update); dmlAndDdl (data + structure update). Valid values for mongo DatabaseType: all (full instance update); database (subscribe to a table); collection (subscribe to a collection).
        /// </summary>
        [JsonProperty("SubscribeMode")]
        public string SubscribeMode{ get; set; }

        /// <summary>
        /// Source database access type. Valid values: extranet (public network); vpncloud (VPN access); dcg (Direct Connect); ccn (CCN); cdb (database); cvm (self-build on CVM); intranet (intranet); vpc (VPC). Note: The specific optional values depend on the current link support capabilities.
        /// </summary>
        [JsonProperty("AccessType")]
        public string AccessType{ get; set; }

        /// <summary>
        /// Database node information
        /// </summary>
        [JsonProperty("Endpoints")]
        public EndpointItem[] Endpoints{ get; set; }

        /// <summary>
        /// Kafka configuration
        /// </summary>
        [JsonProperty("KafkaConfig")]
        public SubscribeKafkaConfig KafkaConfig{ get; set; }

        /// <summary>
        /// Subscription database table information. When SubscribeMode is not all or ddl, SubscribeObjects is a required parameter.
        /// </summary>
        [JsonProperty("SubscribeObjects")]
        public SubscribeObject[] SubscribeObjects{ get; set; }

        /// <summary>
        /// Subscription data format, such as: protobuf, json, avro. Note: The specific optional values depend on the current link support capabilities. For details on the data format, please refer to the consumption demo documentation on the official website.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// mongo optional parameter: output aggregation settings.
        /// </summary>
        [JsonProperty("PipelineInfo")]
        public PipelineInfo[] PipelineInfo{ get; set; }

        /// <summary>
        /// Additional information added for the business. The parameter name is called key, and the parameter value is called value.Optional parameters for mysql: ProcessXA. If true is filled in, it will be processed. If it is left blank or filled with other values, it will not be processed.Optional parameters for mongo: SubscribeType. Currently only changeStream is supported. If not filled in, the default is changeStream.Other businesses currently have no optional parameters.
        /// </summary>
        [JsonProperty("ExtraAttr")]
        public KeyValuePairOption[] ExtraAttr{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubscribeId", this.SubscribeId);
            this.SetParamSimple(map, prefix + "SubscribeMode", this.SubscribeMode);
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamArrayObj(map, prefix + "Endpoints.", this.Endpoints);
            this.SetParamObj(map, prefix + "KafkaConfig.", this.KafkaConfig);
            this.SetParamArrayObj(map, prefix + "SubscribeObjects.", this.SubscribeObjects);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamArrayObj(map, prefix + "PipelineInfo.", this.PipelineInfo);
            this.SetParamArrayObj(map, prefix + "ExtraAttr.", this.ExtraAttr);
        }
    }
}

