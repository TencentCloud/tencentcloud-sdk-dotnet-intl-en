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

namespace TencentCloud.Pts.V20210728.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Scenario : AbstractModel
    {
        
        /// <summary>
        /// Scenario ID.
        /// </summary>
        [JsonProperty("ScenarioId")]
        public string ScenarioId{ get; set; }

        /// <summary>
        /// Scenario name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Scenario description.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Type of scenario. Valid values: 'pts-http' represents the simple mode, 'pts-js' represents the script mode, 'pts-jmeter' represents the JMeter mode.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Scenario status.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Load configuration.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("Load")]
        public Load Load{ get; set; }

        /// <summary>
        /// Deprecated.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("EncodedScripts")]
        public string EncodedScripts{ get; set; }

        /// <summary>
        /// Deprecated.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("Configs")]
        public string[] Configs{ get; set; }

        /// <summary>
        /// Deprecated.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("Extensions")]
        public string[] Extensions{ get; set; }

        /// <summary>
        /// Test datasets.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("Datasets")]
        public TestData[] Datasets{ get; set; }

        /// <summary>
        /// Deprecated.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("SLAId")]
        public string SLAId{ get; set; }

        /// <summary>
        /// CronJob ID.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("CronId")]
        public string CronId{ get; set; }

        /// <summary>
        /// Create time.
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// Update time.
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }

        /// <summary>
        /// Project ID.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// App ID.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// Uin.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// Sub account uin.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("SubAccountUin")]
        public string SubAccountUin{ get; set; }

        /// <summary>
        /// Test scripts.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("TestScripts")]
        public ScriptInfo[] TestScripts{ get; set; }

        /// <summary>
        /// Protocol files.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("Protocols")]
        public ProtocolInfo[] Protocols{ get; set; }

        /// <summary>
        /// Request files.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("RequestFiles")]
        public FileInfo[] RequestFiles{ get; set; }

        /// <summary>
        /// SLA policy.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("SLAPolicy")]
        public SLAPolicy SLAPolicy{ get; set; }

        /// <summary>
        /// Extension plugin files.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("Plugins")]
        public FileInfo[] Plugins{ get; set; }

        /// <summary>
        /// Domain name resolution configuration.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("DomainNameConfig")]
        public DomainNameConfig DomainNameConfig{ get; set; }

        /// <summary>
        /// Notification event hooks.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("NotificationHooks")]
        public NotificationHook[] NotificationHooks{ get; set; }

        /// <summary>
        /// Creator name.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("Owner")]
        public string Owner{ get; set; }

        /// <summary>
        /// Project name.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScenarioId", this.ScenarioId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "Load.", this.Load);
            this.SetParamSimple(map, prefix + "EncodedScripts", this.EncodedScripts);
            this.SetParamArraySimple(map, prefix + "Configs.", this.Configs);
            this.SetParamArraySimple(map, prefix + "Extensions.", this.Extensions);
            this.SetParamArrayObj(map, prefix + "Datasets.", this.Datasets);
            this.SetParamSimple(map, prefix + "SLAId", this.SLAId);
            this.SetParamSimple(map, prefix + "CronId", this.CronId);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "SubAccountUin", this.SubAccountUin);
            this.SetParamArrayObj(map, prefix + "TestScripts.", this.TestScripts);
            this.SetParamArrayObj(map, prefix + "Protocols.", this.Protocols);
            this.SetParamArrayObj(map, prefix + "RequestFiles.", this.RequestFiles);
            this.SetParamObj(map, prefix + "SLAPolicy.", this.SLAPolicy);
            this.SetParamArrayObj(map, prefix + "Plugins.", this.Plugins);
            this.SetParamObj(map, prefix + "DomainNameConfig.", this.DomainNameConfig);
            this.SetParamArrayObj(map, prefix + "NotificationHooks.", this.NotificationHooks);
            this.SetParamSimple(map, prefix + "Owner", this.Owner);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
        }
    }
}

