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

namespace TencentCloud.Tke.V20220501.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Instance : AbstractModel
    {
        
        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Node role: MASTER, WORKER, ETCD, MASTER_ETCD, and ALL. Default value: WORKER
        /// </summary>
        [JsonProperty("InstanceRole")]
        public string InstanceRole{ get; set; }

        /// <summary>
        /// Cause of instance exception (or initialization)
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("FailedReason")]
        public string FailedReason{ get; set; }

        /// <summary>
        /// Instance status
        /// 
        /// - initializing
        /// - running
        /// - failed
        /// </summary>
        [JsonProperty("InstanceState")]
        public string InstanceState{ get; set; }

        /// <summary>
        /// Whether it is unschedulable
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Unschedulable")]
        public bool? Unschedulable{ get; set; }

        /// <summary>
        /// Adding time
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Node private network IP
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("LanIP")]
        public string LanIP{ get; set; }

        /// <summary>
        /// Resource pool ID
        /// 
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("NodePoolId")]
        public string NodePoolId{ get; set; }

        /// <summary>
        /// Native node parameters
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Native")]
        public NativeNodeInfo Native{ get; set; }

        /// <summary>
        /// General node parameters
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Regular")]
        public RegularNodeInfo Regular{ get; set; }

        /// <summary>
        /// Super node parameters
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Super")]
        public SuperNodeInfo Super{ get; set; }

        /// <summary>
        /// Third-party node parameters
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("External")]
        public ExternalNodeInfo External{ get; set; }

        /// <summary>
        /// Node type
        /// 
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceRole", this.InstanceRole);
            this.SetParamSimple(map, prefix + "FailedReason", this.FailedReason);
            this.SetParamSimple(map, prefix + "InstanceState", this.InstanceState);
            this.SetParamSimple(map, prefix + "Unschedulable", this.Unschedulable);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "LanIP", this.LanIP);
            this.SetParamSimple(map, prefix + "NodePoolId", this.NodePoolId);
            this.SetParamObj(map, prefix + "Native.", this.Native);
            this.SetParamObj(map, prefix + "Regular.", this.Regular);
            this.SetParamObj(map, prefix + "Super.", this.Super);
            this.SetParamObj(map, prefix + "External.", this.External);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
        }
    }
}

