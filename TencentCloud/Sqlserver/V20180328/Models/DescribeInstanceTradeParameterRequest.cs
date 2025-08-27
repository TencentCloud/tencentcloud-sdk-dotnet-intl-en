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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstanceTradeParameterRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance AZ, such as ap-guangzhou-1 (Guangzhou Zone 1). Purchasable AZs for an instance can be obtained through the `DescribeZones` API.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Number of CPU cores.
        /// </summary>
        [JsonProperty("Cpu")]
        public ulong? Cpu{ get; set; }

        /// <summary>
        /// Instance memory size in GB.
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// Instance storage capacity in GB.
        /// </summary>
        [JsonProperty("Storage")]
        public long? Storage{ get; set; }

        /// <summary>
        /// Type of purchased instances. HA: high-availability edition (including dual-server high-availability edition and Always On cluster edition); RO: read-only replica edition; SI: single-node edition; BI: business intelligence edition; cvmHA: new high-availability edition; cvmRO: new read-only replica edition; MultiHA: multi-node edition; cvmMultiHA: multi-node cloud disk edition.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Host disk type of purchased instances. CLOUD_HSSD - Enhanced SSD for CVMs, CLOUD_TSSD - Tremendous SSD for CVMs, CLOUD_BSSD - Balanced SSD for CVMs. 
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// Billing mode. Valid value: POSTPAID (pay-as-you-go).
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Number of instances purchased this time. Default value: 1. Maximum value: 10.
        /// </summary>
        [JsonProperty("GoodsNum")]
        public long? GoodsNum{ get; set; }

        /// <summary>
        /// SQL Server version. Valid values: `2008R2` (SQL Server 2008 R2 Enterprise), `2012SP3` (SQL Server 2012 Enterprise), `201202` (SQL Server 2012 Standard), `2014SP2` (SQL Server 2014 Enterprise), 201402 (SQL Server 2014 Standard), `2016SP1` (SQL Server 2016 Enterprise), `201602` (SQL Server 2016 Standard), `2017` (SQL Server 2017 Enterprise), `201702` (SQL Server 2017 Standard), `2019` (SQL Server 2019 Enterprise), `201902` (SQL Server 2019 Standard). Default value: `2008R2`. The available version varies by region, and you can pull the version information by calling the `DescribeProductConfig` API.
        /// </summary>
        [JsonProperty("DBVersion")]
        public string DBVersion{ get; set; }

        /// <summary>
        /// VPC subnet ID in the format of subnet-bdoe83fa. `SubnetId` and `VpcId` should be set or ignored simultaneously.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// VPC ID in the format of vpc-dsp338hz. `SubnetId` and `VpcId` should be set or ignored simultaneously.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Length of purchase of instance. The default value is 1, indicating one month. The value cannot exceed 48.
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// Security group list, which contains security group IDs in the format of sg-xxx.
        /// </summary>
        [JsonProperty("SecurityGroupList")]
        public string[] SecurityGroupList{ get; set; }

        /// <summary>
        /// Auto-renewal flag. 0: normal renewal, 1: auto-renewal. Default value: 1.
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// Configuration of the maintenance window, which specifies the day of the week when maintenance can be performed. Valid values: 1 (Monday), 2 (Tuesday), 3 (Wednesday), 4 (Thursday), 5 (Friday), 6 (Saturday), 7 (Sunday).
        /// </summary>
        [JsonProperty("Weekly")]
        public long?[] Weekly{ get; set; }

        /// <summary>
        /// Configuration of the maintenance window, which specifies the start time of daily maintenance.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Configuration of the maintenance window, which specifies the maintenance duration in hours.
        /// </summary>
        [JsonProperty("Span")]
        public long? Span{ get; set; }

        /// <summary>
        /// Whether to deploy across availability zones. Default value: false.
        /// </summary>
        [JsonProperty("MultiZones")]
        public bool? MultiZones{ get; set; }

        /// <summary>
        /// Tags associated with the instances to be created.
        /// </summary>
        [JsonProperty("ResourceTags")]
        public ResourceTag[] ResourceTags{ get; set; }

        /// <summary>
        /// System time zone. Default value: `China Standard Time`.
        /// </summary>
        [JsonProperty("TimeZone")]
        public string TimeZone{ get; set; }

        /// <summary>
        /// Collation of system character sets. Default value: `Chinese_PRC_CI_AS`.
        /// </summary>
        [JsonProperty("Collation")]
        public string Collation{ get; set; }

        /// <summary>
        /// Whether it is a multi-node architecture instance. Default value: `false`.
        /// </summary>
        [JsonProperty("MultiNodes")]
        public bool? MultiNodes{ get; set; }

        /// <summary>
        /// The zone in which the standby node is available. Default is empty. If it is a multi-node architecture, it must be transmitted. When MultiNodes = true, the availability zones of the primary and standby nodes cannot all be the same. The minimum number of availability zones for the standby nodes is 2, and the maximum is 5.
        /// </summary>
        [JsonProperty("DrZones")]
        public string[] DrZones{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "DBVersion", this.DBVersion);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamArraySimple(map, prefix + "SecurityGroupList.", this.SecurityGroupList);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamArraySimple(map, prefix + "Weekly.", this.Weekly);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Span", this.Span);
            this.SetParamSimple(map, prefix + "MultiZones", this.MultiZones);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
            this.SetParamSimple(map, prefix + "Collation", this.Collation);
            this.SetParamSimple(map, prefix + "MultiNodes", this.MultiNodes);
            this.SetParamArraySimple(map, prefix + "DrZones.", this.DrZones);
        }
    }
}

