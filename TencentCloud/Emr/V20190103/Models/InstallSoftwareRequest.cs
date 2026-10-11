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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstallSoftwareRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Cluster ID.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Component version, for example, presto-0.161. You can view the components that can be installed on the current cluster via InstallSoftWareInfo.</p>
        /// </summary>
        [JsonProperty("SoftInfo")]
        public string[] SoftInfo{ get; set; }

        /// <summary>
        /// <p>If you use a monthly subscription cluster and need to purchase a CDB, determine whether to enable auto-renewal for the CDB. Default value: AUTO_RENEW. If auto-renewal is disabled for the newly-added CDB, fill in NOT_AUTO_RENEW.</p>
        /// </summary>
        [JsonProperty("CdbAutoRenew")]
        public string CdbAutoRenew{ get; set; }

        /// <summary>
        /// <p>Hive shared metadata database type. Valid values:</p><li>EMR_NEW_META: created by the cluster by default</li><li>EMR_EXIT_METE: EMR-MetaDB specified by the cluster</li><li>USER_CUSTOM_META: custom MetaDB used by the cluster</li>
        /// </summary>
        [JsonProperty("MetaType")]
        public string MetaType{ get; set; }

        /// <summary>
        /// <p>EMR-MetaDB instance.</p>
        /// </summary>
        [JsonProperty("UnifyMetaInstanceId")]
        public string UnifyMetaInstanceId{ get; set; }

        /// <summary>
        /// <p>Custom MetaDB information.</p>
        /// </summary>
        [JsonProperty("MetaDBInfo")]
        public CustomMetaInfo MetaDBInfo{ get; set; }

        /// <summary>
        /// <p>Shared component information.</p>
        /// </summary>
        [JsonProperty("ExternalService")]
        public ExternalService[] ExternalService{ get; set; }

        /// <summary>
        /// <p>Tag information.</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>Pod specification information of the role.</p>
        /// </summary>
        [JsonProperty("CloudResources")]
        public CloudResource[] CloudResources{ get; set; }

        /// <summary>
        /// <p>Custom deployment information.</p>
        /// </summary>
        [JsonProperty("ServiceDeployInfoList")]
        public ServiceDeployInfo[] ServiceDeployInfoList{ get; set; }

        /// <summary>
        /// <p>Database version.</p>
        /// </summary>
        [JsonProperty("DefaultMetaVersion")]
        public string DefaultMetaVersion{ get; set; }

        /// <summary>
        /// <p>Whether to enable audit.</p>
        /// </summary>
        [JsonProperty("NeedCdbAudit")]
        public long? NeedCdbAudit{ get; set; }

        /// <summary>
        /// <p>Additional container configuration.</p>
        /// </summary>
        [JsonProperty("ContainerExtraConf")]
        public ContainerExtraConf ContainerExtraConf{ get; set; }

        /// <summary>
        /// <p>Whether to forcibly check the validity of custom components. Currently, it is available only for the Terraform side.</p>
        /// </summary>
        [JsonProperty("CheckServiceDeployInfo")]
        public bool? CheckServiceDeployInfo{ get; set; }

        /// <summary>
        /// <p>Custom MetaDB information.</p>
        /// </summary>
        [JsonProperty("MetaDBGroupInfo")]
        public CustomMetaDBInfo[] MetaDBGroupInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "SoftInfo.", this.SoftInfo);
            this.SetParamSimple(map, prefix + "CdbAutoRenew", this.CdbAutoRenew);
            this.SetParamSimple(map, prefix + "MetaType", this.MetaType);
            this.SetParamSimple(map, prefix + "UnifyMetaInstanceId", this.UnifyMetaInstanceId);
            this.SetParamObj(map, prefix + "MetaDBInfo.", this.MetaDBInfo);
            this.SetParamArrayObj(map, prefix + "ExternalService.", this.ExternalService);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArrayObj(map, prefix + "CloudResources.", this.CloudResources);
            this.SetParamArrayObj(map, prefix + "ServiceDeployInfoList.", this.ServiceDeployInfoList);
            this.SetParamSimple(map, prefix + "DefaultMetaVersion", this.DefaultMetaVersion);
            this.SetParamSimple(map, prefix + "NeedCdbAudit", this.NeedCdbAudit);
            this.SetParamObj(map, prefix + "ContainerExtraConf.", this.ContainerExtraConf);
            this.SetParamSimple(map, prefix + "CheckServiceDeployInfo", this.CheckServiceDeployInfo);
            this.SetParamArrayObj(map, prefix + "MetaDBGroupInfo.", this.MetaDBGroupInfo);
        }
    }
}

