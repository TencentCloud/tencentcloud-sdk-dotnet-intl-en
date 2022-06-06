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
        /// Upgrade the SQL Server version. Supported versions include SQL Server 2008 Enterprise (`2008R2`), SQL Server 2012 Enterprise (`2012SP3`), etc. As the purchasable versions are region-specific, you can use the `DescribeProductConfig` API to query the information of purchasable versions in each region. Downgrading is unsupported. If this parameter is left empty, the SQL Server version will not be changed.
        /// </summary>
        [JsonProperty("DBVersion")]
        public string DBVersion{ get; set; }

        /// <summary>
        /// Upgrade the high availability architecture from image-based disaster recovery to Always On cluster disaster recovery. This parameter is valid only for instances which support Always On high availability and run SQL Server 2017 or later. Neither downgrading to image-based disaster recovery nor upgrading from cluster disaster recovery to Always On disaster recovery is supported. If this parameter is left empty, the high availability architecture will not be changed.
        /// </summary>
        [JsonProperty("HAType")]
        public string HAType{ get; set; }

        /// <summary>
        /// Change the instance deployment scheme. Valid values: `SameZones` (change to single-AZ deployment, which does not support cross-AZ disaster recovery), `MultiZones` (change to multi-AZ deployment, which supports cross-AZ disaster recovery).
        /// </summary>
        [JsonProperty("MultiZones")]
        public string MultiZones{ get; set; }

        /// <summary>
        /// The time when configuration adjustment task is performed. Valid values: `0` (execute immediately), `1` (execute during maintenance time). Default value: `1`.
        /// </summary>
        [JsonProperty("WaitSwitch")]
        public long? WaitSwitch{ get; set; }


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
            this.SetParamSimple(map, prefix + "DBVersion", this.DBVersion);
            this.SetParamSimple(map, prefix + "HAType", this.HAType);
            this.SetParamSimple(map, prefix + "MultiZones", this.MultiZones);
            this.SetParamSimple(map, prefix + "WaitSwitch", this.WaitSwitch);
        }
    }
}

