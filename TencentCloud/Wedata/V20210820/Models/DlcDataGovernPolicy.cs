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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DlcDataGovernPolicy : AbstractModel
    {
        
        /// <summary>
        /// Data Layout Governance Item
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RewriteDataPolicy")]
        public DlcRewriteDataInfo RewriteDataPolicy{ get; set; }

        /// <summary>
        /// Snapshot Expiration Governance Item
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ExpiredSnapshotsPolicy")]
        public DlcExpiredSnapshotsInfo ExpiredSnapshotsPolicy{ get; set; }

        /// <summary>
        /// Remove Isolated Files Governance Item
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RemoveOrphanFilesPolicy")]
        public DlcRemoveOrphanFilesInfo RemoveOrphanFilesPolicy{ get; set; }

        /// <summary>
        /// Merge Metadata Manifests Governance Item
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("MergeManifestsPolicy")]
        public DlcMergeManifestsInfo MergeManifestsPolicy{ get; set; }

        /// <summary>
        /// Integration Library Rules: default (Default Inheritance), none (No Inheritance)
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("InheritDataBase")]
        public string InheritDataBase{ get; set; }

        /// <summary>
        /// Governance Rule Types, Customize: Custom Definition; Intelligence: Intelligent Governance
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// Governance Engine
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("GovernEngine")]
        public string GovernEngine{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "RewriteDataPolicy.", this.RewriteDataPolicy);
            this.SetParamObj(map, prefix + "ExpiredSnapshotsPolicy.", this.ExpiredSnapshotsPolicy);
            this.SetParamObj(map, prefix + "RemoveOrphanFilesPolicy.", this.RemoveOrphanFilesPolicy);
            this.SetParamObj(map, prefix + "MergeManifestsPolicy.", this.MergeManifestsPolicy);
            this.SetParamSimple(map, prefix + "InheritDataBase", this.InheritDataBase);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "GovernEngine", this.GovernEngine);
        }
    }
}

