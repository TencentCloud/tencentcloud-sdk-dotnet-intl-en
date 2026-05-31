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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CynosdbCluster : AbstractModel
    {
        
        /// <summary>
        /// <p>Cluster status. Valid values include:<br>creating: Creating<br>running: Running<br>isolating: Isolation<br>isolated: Isolated<br>activating: De-isolating<br>offlining: Offline<br>offlined: Offline<br>deleting: Deleting<br>deleted: Deleted</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Update time.</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>AZ.</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>Cluster name.</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>Region</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>Database version</p>
        /// </summary>
        [JsonProperty("DbVersion")]
        public string DbVersion{ get; set; }

        /// <summary>
        /// <p>Cluster ID.</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>Number of instances</p>
        /// </summary>
        [JsonProperty("InstanceNum")]
        public long? InstanceNum{ get; set; }

        /// <summary>
        /// <p>User uin</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>Engine type</p>
        /// </summary>
        [JsonProperty("DbType")]
        public string DbType{ get; set; }

        /// <summary>
        /// <p>User appid</p>
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// <p>Cluster status description</p>
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// <p>Cluster creation time</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Payment mode. 0: pay-as-you-go; 1: monthly subscription</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// <p>End time</p>
        /// </summary>
        [JsonProperty("PeriodEndTime")]
        public string PeriodEndTime{ get; set; }

        /// <summary>
        /// <p>Cluster read/write vip</p>
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// <p>Cluster read/write vport</p>
        /// </summary>
        [JsonProperty("Vport")]
        public long? Vport{ get; set; }

        /// <summary>
        /// <p>Project ID.</p>
        /// </summary>
        [JsonProperty("ProjectID")]
        public long? ProjectID{ get; set; }

        /// <summary>
        /// <p>VPC ID</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>Subnet ID.</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>cynos kernel version</p>
        /// </summary>
        [JsonProperty("CynosVersion")]
        public string CynosVersion{ get; set; }

        /// <summary>
        /// <p>cynos version tag</p>
        /// </summary>
        [JsonProperty("CynosVersionTag")]
        public string CynosVersionTag{ get; set; }

        /// <summary>
        /// <p>Storage capacity</p>
        /// </summary>
        [JsonProperty("StorageLimit")]
        public long? StorageLimit{ get; set; }

        /// <summary>
        /// <p>Renewal flag</p>
        /// </summary>
        [JsonProperty("RenewFlag")]
        public long? RenewFlag{ get; set; }

        /// <summary>
        /// <p>Currently processing task</p>
        /// </summary>
        [JsonProperty("ProcessingTask")]
        public string ProcessingTask{ get; set; }

        /// <summary>
        /// <p>Task array of the cluster</p>
        /// </summary>
        [JsonProperty("Tasks")]
        public ObjectTask[] Tasks{ get; set; }

        /// <summary>
        /// <p>tag Array of cluster binding</p>
        /// </summary>
        [JsonProperty("ResourceTags")]
        public Tag[] ResourceTags{ get; set; }

        /// <summary>
        /// <p>Db type (NORMAL, SERVERLESS)</p>
        /// </summary>
        [JsonProperty("DbMode")]
        public string DbMode{ get; set; }

        /// <summary>
        /// <p>When the Db type is SERVERLESS, the SERVERLESS cluster status. Available values:<br>resume<br>pause</p>
        /// </summary>
        [JsonProperty("ServerlessStatus")]
        public string ServerlessStatus{ get; set; }

        /// <summary>
        /// <p>Cluster Prepaid storage size</p>
        /// </summary>
        [JsonProperty("Storage")]
        public long? Storage{ get; set; }

        /// <summary>
        /// <p>Storage ID of cluster storage in prepayment, used for prepaid storage configuration change</p>
        /// </summary>
        [JsonProperty("StorageId")]
        public string StorageId{ get; set; }

        /// <summary>
        /// <p>Cluster storage payment mode. 0: pay-as-you-go; 1: monthly subscription</p>
        /// </summary>
        [JsonProperty("StoragePayMode")]
        public long? StoragePayMode{ get; set; }

        /// <summary>
        /// <p>Minimum storage of the cluster compute specification</p>
        /// </summary>
        [JsonProperty("MinStorageSize")]
        public long? MinStorageSize{ get; set; }

        /// <summary>
        /// <p>Maximum storage value of the cluster compute specification</p>
        /// </summary>
        [JsonProperty("MaxStorageSize")]
        public long? MaxStorageSize{ get; set; }

        /// <summary>
        /// <p>Cluster network information</p>
        /// </summary>
        [JsonProperty("NetAddrs")]
        public NetAddr[] NetAddrs{ get; set; }

        /// <summary>
        /// <p>Physical AZ</p>
        /// </summary>
        [JsonProperty("PhysicalZone")]
        public string PhysicalZone{ get; set; }

        /// <summary>
        /// <p>Primary AZ</p>
        /// </summary>
        [JsonProperty("MasterZone")]
        public string MasterZone{ get; set; }

        /// <summary>
        /// <p>Whether there is a secondary AZ</p>
        /// </summary>
        [JsonProperty("HasSlaveZone")]
        public string HasSlaveZone{ get; set; }

        /// <summary>
        /// <p>Secondary AZ</p>
        /// </summary>
        [JsonProperty("SlaveZones")]
        public string[] SlaveZones{ get; set; }

        /// <summary>
        /// <p>Business type</p>
        /// </summary>
        [JsonProperty("BusinessType")]
        public string BusinessType{ get; set; }

        /// <summary>
        /// <p>Freeze or not</p>
        /// </summary>
        [JsonProperty("IsFreeze")]
        public string IsFreeze{ get; set; }

        /// <summary>
        /// <p>Order source</p>
        /// </summary>
        [JsonProperty("OrderSource")]
        public string OrderSource{ get; set; }

        /// <summary>
        /// <p>Capacity</p>
        /// </summary>
        [JsonProperty("Ability")]
        public Ability Ability{ get; set; }

        /// <summary>
        /// <p>Instance bind resource package info (here only return storage resource package, for example packageType=DISK)</p>
        /// </summary>
        [JsonProperty("ResourcePackages")]
        public ResourcePackage[] ResourcePackages{ get; set; }

        /// <summary>
        /// <p>Global database unique ID</p>
        /// </summary>
        [JsonProperty("GdnId")]
        public string GdnId{ get; set; }

        /// <summary>
        /// <p>Cluster role. Primary cluster - primary, slave cluster - standby. If GdnId is empty, the field is invalid.</p>
        /// </summary>
        [JsonProperty("GdnRole")]
        public string GdnRole{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "DbVersion", this.DbVersion);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "InstanceNum", this.InstanceNum);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "DbType", this.DbType);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "PeriodEndTime", this.PeriodEndTime);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "ProjectID", this.ProjectID);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "CynosVersion", this.CynosVersion);
            this.SetParamSimple(map, prefix + "CynosVersionTag", this.CynosVersionTag);
            this.SetParamSimple(map, prefix + "StorageLimit", this.StorageLimit);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "ProcessingTask", this.ProcessingTask);
            this.SetParamArrayObj(map, prefix + "Tasks.", this.Tasks);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "DbMode", this.DbMode);
            this.SetParamSimple(map, prefix + "ServerlessStatus", this.ServerlessStatus);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "StorageId", this.StorageId);
            this.SetParamSimple(map, prefix + "StoragePayMode", this.StoragePayMode);
            this.SetParamSimple(map, prefix + "MinStorageSize", this.MinStorageSize);
            this.SetParamSimple(map, prefix + "MaxStorageSize", this.MaxStorageSize);
            this.SetParamArrayObj(map, prefix + "NetAddrs.", this.NetAddrs);
            this.SetParamSimple(map, prefix + "PhysicalZone", this.PhysicalZone);
            this.SetParamSimple(map, prefix + "MasterZone", this.MasterZone);
            this.SetParamSimple(map, prefix + "HasSlaveZone", this.HasSlaveZone);
            this.SetParamArraySimple(map, prefix + "SlaveZones.", this.SlaveZones);
            this.SetParamSimple(map, prefix + "BusinessType", this.BusinessType);
            this.SetParamSimple(map, prefix + "IsFreeze", this.IsFreeze);
            this.SetParamSimple(map, prefix + "OrderSource", this.OrderSource);
            this.SetParamObj(map, prefix + "Ability.", this.Ability);
            this.SetParamArrayObj(map, prefix + "ResourcePackages.", this.ResourcePackages);
            this.SetParamSimple(map, prefix + "GdnId", this.GdnId);
            this.SetParamSimple(map, prefix + "GdnRole", this.GdnRole);
        }
    }
}

