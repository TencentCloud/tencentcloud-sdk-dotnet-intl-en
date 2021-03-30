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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyInstanceAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Maximum retention period in minutes for instance log, which can be up to 30 days. 0 indicates not to enable the log retention period policy
        /// </summary>
        [JsonProperty("MsgRetentionTime")]
        public long? MsgRetentionTime{ get; set; }

        /// <summary>
        /// Instance name string of up to 64 characters, which must begin with a letter and can contain letters, digits, and dashes (`-`)
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Instance configuration
        /// </summary>
        [JsonProperty("Config")]
        public ModifyInstanceAttributesConfig Config{ get; set; }

        /// <summary>
        /// Dynamic message retention policy configuration
        /// </summary>
        [JsonProperty("DynamicRetentionConfig")]
        public DynamicRetentionTime DynamicRetentionConfig{ get; set; }

        /// <summary>
        /// Modification of the rebalancing time after upgrade
        /// </summary>
        [JsonProperty("RebalanceTime")]
        public long? RebalanceTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "MsgRetentionTime", this.MsgRetentionTime);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamObj(map, prefix + "Config.", this.Config);
            this.SetParamObj(map, prefix + "DynamicRetentionConfig.", this.DynamicRetentionConfig);
            this.SetParamSimple(map, prefix + "RebalanceTime", this.RebalanceTime);
        }
    }
}

