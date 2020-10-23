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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DiskOperationLog : AbstractModel
    {
        
        /// <summary>
        /// UIN of operator.
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// Operation type. Value range:
        /// CBS_OPERATION_ATTACH: Mount cloud disk
        /// CBS_OPERATION_DETACH: Unmount cloud disk
        /// CBS_OPERATION_RENEW: Renew
        /// CBS_OPERATION_EXPAND: Expand
        /// CBS_OPERATION_CREATE: Create
        /// CBS_OPERATION_ISOLATE: Isolate
        /// CBS_OPERATION_MODIFY: Modify cloud disk attributes
        /// ASP_OPERATION_BIND: Associate scheduled snapshot policy
        /// ASP_OPERATION_UNBIND: Cancel associated scheduled snapshot policy
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// Cloud disk ID of operation.
        /// </summary>
        [JsonProperty("DiskId")]
        public string DiskId{ get; set; }

        /// <summary>
        /// Status of operation. Value range:
        /// SUCCESS: Operation successful 
        /// FAILED: Operation failed 
        /// PROCESSING: Operation in process
        /// </summary>
        [JsonProperty("OperationState")]
        public string OperationState{ get; set; }

        /// <summary>
        /// Start time
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "DiskId", this.DiskId);
            this.SetParamSimple(map, prefix + "OperationState", this.OperationState);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

