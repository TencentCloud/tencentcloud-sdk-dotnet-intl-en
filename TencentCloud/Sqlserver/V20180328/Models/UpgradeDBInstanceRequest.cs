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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpgradeDBInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID in the format of mssql-j8kv137v
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Memory size after instance upgrade in GB, which cannot be smaller than the current instance memory size
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// Storage capacity after instance upgrade in GB, which cannot be smaller than the current instance storage capacity
        /// </summary>
        [JsonProperty("Storage")]
        public long? Storage{ get; set; }

        /// <summary>
        /// Whether to automatically use vouchers. 0: no, 1: yes. Default value: 0
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public long? AutoVoucher{ get; set; }

        /// <summary>
        /// Voucher ID (currently, only one voucher can be used per order)
        /// </summary>
        [JsonProperty("VoucherIds")]
        public string[] VoucherIds{ get; set; }

        /// <summary>
        /// The number of CUP cores after the instance is upgraded.
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamArraySimple(map, prefix + "VoucherIds.", this.VoucherIds);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
        }
    }
}

