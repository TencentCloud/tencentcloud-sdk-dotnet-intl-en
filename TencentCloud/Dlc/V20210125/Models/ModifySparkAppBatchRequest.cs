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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifySparkAppBatchRequest : AbstractModel
    {
        
        /// <summary>
        /// The list of the IDs of the Spark job tasks to be modified in batches.
        /// </summary>
        [JsonProperty("SparkAppId")]
        public string[] SparkAppId{ get; set; }

        /// <summary>
        /// The engine ID.
        /// </summary>
        [JsonProperty("DataEngine")]
        public string DataEngine{ get; set; }

        /// <summary>
        /// The driver size.
        /// Valid values for the standard resource type: `small`, `medium`, `large`, and `xlarge`.
        /// Valid values for the memory resource type: `m.small`, `m.medium`, `m.large`, and `m.xlarge`.
        /// </summary>
        [JsonProperty("AppDriverSize")]
        public string AppDriverSize{ get; set; }

        /// <summary>
        /// The executor size.
        /// Valid values for the standard resource type: `small`, `medium`, `large`, and `xlarge`.
        /// Valid values for the memory resource type: `m.small`, `m.medium`, `m.large`, and `m.xlarge`.
        /// </summary>
        [JsonProperty("AppExecutorSize")]
        public string AppExecutorSize{ get; set; }

        /// <summary>
        /// The executor count. The minimum value is 1 and the maximum value is less than the cluster specification.
        /// </summary>
        [JsonProperty("AppExecutorNums")]
        public ulong? AppExecutorNums{ get; set; }

        /// <summary>
        /// The maximum executor count (in dynamic configuration scenarios). The minimum value is 1 and the maximum value is less than the cluster specification. If you set `ExecutorMaxNumbers` to a value smaller than that of `ExecutorNums`, the value of `ExecutorMaxNumbers` is automatically changed to that of `ExecutorNums`.
        /// </summary>
        [JsonProperty("AppExecutorMaxNumbers")]
        public ulong? AppExecutorMaxNumbers{ get; set; }

        /// <summary>
        /// Whether to inherit the task resource configuration from the cluster template. Valid values: `0` (default): No; `1`: Yes.
        /// </summary>
        [JsonProperty("IsInherit")]
        public ulong? IsInherit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "SparkAppId.", this.SparkAppId);
            this.SetParamSimple(map, prefix + "DataEngine", this.DataEngine);
            this.SetParamSimple(map, prefix + "AppDriverSize", this.AppDriverSize);
            this.SetParamSimple(map, prefix + "AppExecutorSize", this.AppExecutorSize);
            this.SetParamSimple(map, prefix + "AppExecutorNums", this.AppExecutorNums);
            this.SetParamSimple(map, prefix + "AppExecutorMaxNumbers", this.AppExecutorMaxNumbers);
            this.SetParamSimple(map, prefix + "IsInherit", this.IsInherit);
        }
    }
}

