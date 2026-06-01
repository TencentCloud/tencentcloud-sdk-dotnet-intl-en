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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpgradeDBInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Instance ID, in the format such as cdb-c1nl9rpv or cdbro-c1nl9rpv. This matches the instance ID displayed on the TencentDB console. You can obtain it through the <a href="https://www.tencentcloud.com/document/api/236/15872?from_cn_redirect=1">Query Instance List</a> API, with its value being the InstanceId field in the output parameter.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Memory size after upgrade, unit: MB. To ensure the validity of the imported Memory value, please use the <a href="https://www.tencentcloud.com/document/product/236/17229?from_cn_redirect=1">obtain the purchasable specifications of cloud databases</a> API to get the upgradeable memory specifications.<br>Note: If you perform business migration, fill in the instance specification (CPU, memory), otherwise the system will use the minimum allowed specification by default.</p>
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// <p>Disk size after upgrade, unit: GB. To ensure the validity of the imported Volume value, please use the <a href="https://www.tencentcloud.com/document/product/236/17229?from_cn_redirect=1">obtain the purchasable specifications of cloud databases</a> API to get the upgradeable disk range.</p>
        /// </summary>
        [JsonProperty("Volume")]
        public long? Volume{ get; set; }

        /// <summary>
        /// <p>Data replication method. Supported values include: 0 - async replication, 1 - semi-sync replication, 2 - strong sync replication. Specify this parameter when upgrading the primary instance. This parameter is invalid when upgrading a read-only instance or disaster recovery instance.</p>
        /// </summary>
        [JsonProperty("ProtectMode")]
        public long? ProtectMode{ get; set; }

        /// <summary>
        /// <p>Deployment mode, defaults to 0. Supported values include: 0 - single-AZ deployment, 1 - multi-AZ deployment. You can specify this parameter when upgrading the primary instance. This parameter is invalid when upgrading a read-only instance or disaster recovery instance.</p>
        /// </summary>
        [JsonProperty("DeployMode")]
        public long? DeployMode{ get; set; }

        /// <summary>
        /// <p>The availability zone information of standby database 1 matches the Zone parameter of the instance by default. You can specify this parameter when upgrading the primary instance to multi-AZ deployment. This parameter is invalid when upgrading a read-only instance or disaster recovery instance. You can query the supported availability zones via the <a href="https://www.tencentcloud.com/document/product/236/17229?from_cn_redirect=1">obtain the purchasable specifications of cloud databases</a> API.</p>
        /// </summary>
        [JsonProperty("SlaveZone")]
        public string SlaveZone{ get; set; }

        /// <summary>
        /// <p>Database engine version of the primary instance. Supported values include 5.5, 5.6, 5.7, and 8.0.<br>Note: Please use the <a href="https://www.tencentcloud.com/document/api/236/15870?from_cn_redirect=1">UpgradeDBInstanceEngineVersion</a> API to upgrade the database version.</p>
        /// </summary>
        [JsonProperty("EngineVersion")]
        public string EngineVersion{ get; set; }

        /// <summary>
        /// <p>The way to switch to a new instance defaults to 0. Supported values include: 0 - switch immediately, 1 - switch within a time window. When the value is 1, during the upgrade, the process to switch to a new instance will be performed within the time window, or the user can actively call the API <a href="https://www.tencentcloud.com/document/product/236/15864?from_cn_redirect=1">Switch to a New Instance</a> to trigger the process.</p>
        /// </summary>
        [JsonProperty("WaitSwitch")]
        public long? WaitSwitch{ get; set; }

        /// <summary>
        /// <p>The availability zone information of standby 2 is empty by default. You can specify this parameter when upgrading the primary instance, but it is invalid when upgrading a read-only instance or disaster recovery instance. Query the supported AZs via the <a href="https://www.tencentcloud.com/document/product/236/17229?from_cn_redirect=1">obtain the purchasable specifications of cloud databases</a> API.<br>Remark: To downgrade a three-node instance to a two-node one, set this parameter to empty to achieve it.</p>
        /// </summary>
        [JsonProperty("BackupZone")]
        public string BackupZone{ get; set; }

        /// <summary>
        /// <p>Instance type, defaults to master. Supported values include: master - refers to the primary instance, dr - refers to the disaster recovery instance, ro - refers to the read-only instance.</p>
        /// </summary>
        [JsonProperty("InstanceRole")]
        public string InstanceRole{ get; set; }

        /// <summary>
        /// <p>Instance isolation type. Supported values include "UNIVERSAL" - general-purpose instance, "EXCLUSIVE" - dedicated instance, "BASIC" - BASIC edition instance.</p>
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// <p>Number of cpu cores of the instance after upgrade. If not provided, the system will automatically fill in the minimum allowed specification based on the Memory size specified by Memory.<br>Description: If you need to migrate business, make sure to fill in the instance specification (cpu, Memory). Otherwise, the system will use the minimum allowed specification by default.</p>
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// <p>Whether to perform Rapid Configuration Change. 0-Normal upgrade, 1-Rapid Configuration Change, 2-Precedence to rapid change. Selecting Rapid Configuration Change will validate whether it is possible to perform ultra-fast reconfiguration based on resource status. If conditions are met, ultra-fast reconfiguration will be performed; otherwise, error information will be returned.</p>
        /// </summary>
        [JsonProperty("FastUpgrade")]
        public long? FastUpgrade{ get; set; }

        /// <summary>
        /// <p>Delay threshold. Value ranges from 1 to 10, default value is 10.</p>
        /// </summary>
        [JsonProperty("MaxDelayTime")]
        public long? MaxDelayTime{ get; set; }

        /// <summary>
        /// <p>Whether to perform cross-region migration. 0 - ordinary migration, 1 - cross-region migration, default value is 0. When set to 1, it supports changes to the primary node availability zone of the instance.</p>
        /// </summary>
        [JsonProperty("CrossCluster")]
        public long? CrossCluster{ get; set; }

        /// <summary>
        /// <p>Primary node availability zone. This parameter is valid only when cross-AZ migration. You can only migrate in the same region.</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>For cross-cluster migration scenarios, select the processing logic for intra-AZ read-only instances. together-intra-AZ read-only instances migrate with the primary instance to the target availability zone (default option), severally-intra-AZ read-only instances maintain the original deployment mode and do not move to the target availability zone.</p>
        /// </summary>
        [JsonProperty("RoTransType")]
        public string RoTransType{ get; set; }

        /// <summary>
        /// <p>Topology configuration of cloud disk edition nodes.</p>
        /// </summary>
        [JsonProperty("ClusterTopology")]
        public ClusterTopology ClusterTopology{ get; set; }

        /// <summary>
        /// <p>Check whether in-place upgrade requires restart. 1-Check, 0-Do not check. If the value is 1 and the check shows that in-place upgrade must be restarted, the upgrade will be stopped and a notification will be returned. If in-place upgrade does not require restart, the upgrade process will proceed normally.</p>
        /// </summary>
        [JsonProperty("CheckFastUpgradeReboot")]
        public long? CheckFastUpgradeReboot{ get; set; }

        /// <summary>
        /// <p>Data validation sensitivity. This parameter is used for non-Rapid Configuration Change scenarios. Sensitivity is calculated based on current instance specifications to determine cpu resource usage for data comparison during the migration process. Corresponding options are: "high", "normal", "low", empty by default. Parameter explanation: "high": Corresponds to high in the console, not recommended when database load is too high. "normal": Corresponds to standard in the console. "low": Corresponds to low in the console.</p>
        /// </summary>
        [JsonProperty("DataCheckSensitive")]
        public string DataCheckSensitive{ get; set; }

        /// <summary>
        /// <p>AZ information of standby database 3 is empty by default. You can specify this parameter when you proceed to purchase a four-node primary instance.</p>
        /// </summary>
        [JsonProperty("FourthZone")]
        public string FourthZone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "ProtectMode", this.ProtectMode);
            this.SetParamSimple(map, prefix + "DeployMode", this.DeployMode);
            this.SetParamSimple(map, prefix + "SlaveZone", this.SlaveZone);
            this.SetParamSimple(map, prefix + "EngineVersion", this.EngineVersion);
            this.SetParamSimple(map, prefix + "WaitSwitch", this.WaitSwitch);
            this.SetParamSimple(map, prefix + "BackupZone", this.BackupZone);
            this.SetParamSimple(map, prefix + "InstanceRole", this.InstanceRole);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "FastUpgrade", this.FastUpgrade);
            this.SetParamSimple(map, prefix + "MaxDelayTime", this.MaxDelayTime);
            this.SetParamSimple(map, prefix + "CrossCluster", this.CrossCluster);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "RoTransType", this.RoTransType);
            this.SetParamObj(map, prefix + "ClusterTopology.", this.ClusterTopology);
            this.SetParamSimple(map, prefix + "CheckFastUpgradeReboot", this.CheckFastUpgradeReboot);
            this.SetParamSimple(map, prefix + "DataCheckSensitive", this.DataCheckSensitive);
            this.SetParamSimple(map, prefix + "FourthZone", this.FourthZone);
        }
    }
}

