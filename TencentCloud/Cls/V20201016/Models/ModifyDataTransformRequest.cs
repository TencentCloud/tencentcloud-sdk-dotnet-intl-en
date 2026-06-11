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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDataTransformRequest : AbstractModel
    {
        
        /// <summary>
        /// Data processing task ID
        /// -Get the data processing task Id by [searching data processing task list basic information](https://www.tencentcloud.com/document/product/614/72182?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Processing task name
        /// -Get the name of a data processing task by [searching data processing task list basic information](https://www.tencentcloud.com/document/product/614/72182?from_cn_redirect=1).
        /// 
        /// Name limit
        /// -Cannot be an empty string
        /// -Cannot contain character '|'
        /// -Up to 255 characters
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Processing statement. When FuncType is 2, EtlContent must use [log_auto_output](https://www.tencentcloud.com/document/product/614/70733?from_cn_redirect=1#b3c58797-4825-4807-bef4-68106e25024f). 
        /// 
        /// Other reference documents:
        /// 
        /// -[Create a processing task](https://www.tencentcloud.com/document/product/614/63940?from_cn_redirect=1) 
        /// -[Function overview](https://www.tencentcloud.com/document/product/614/70395?from_cn_redirect=1)
        /// </summary>
        [JsonProperty("EtlContent")]
        public string EtlContent{ get; set; }

        /// <summary>
        /// Task status. Valid values: 1 (enabled) and 2 (disabled).
        /// </summary>
        [JsonProperty("EnableFlag")]
        public long? EnableFlag{ get; set; }

        /// <summary>
        /// Destination topic ID and alias of the data processing task
        /// </summary>
        [JsonProperty("DstResources")]
        public DataTransformResouceInfo[] DstResources{ get; set; }

        /// <summary>
        /// Whether to discard log data after the limit is exceeded
        /// </summary>
        [JsonProperty("BackupGiveUpData")]
        public bool? BackupGiveUpData{ get; set; }

        /// <summary>
        /// Whether to enable delivery service log. 1 for disabled, 2 for enabled
        /// </summary>
        [JsonProperty("HasServicesLog")]
        public ulong? HasServicesLog{ get; set; }

        /// <summary>
        /// Whether to keep the failure log status. Valid values: 1: no; 2: yes.
        /// </summary>
        [JsonProperty("KeepFailureLog")]
        public ulong? KeepFailureLog{ get; set; }

        /// <summary>
        /// Field name of a failed log.
        /// </summary>
        [JsonProperty("FailureLogKey")]
        public string FailureLogKey{ get; set; }

        /// <summary>
        /// External data source information
        /// </summary>
        [JsonProperty("DataTransformSqlDataSources")]
        public DataTransformSqlDataSource[] DataTransformSqlDataSources{ get; set; }

        /// <summary>
        /// Set environment variable
        /// </summary>
        [JsonProperty("EnvInfos")]
        public EnvInfo[] EnvInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "EtlContent", this.EtlContent);
            this.SetParamSimple(map, prefix + "EnableFlag", this.EnableFlag);
            this.SetParamArrayObj(map, prefix + "DstResources.", this.DstResources);
            this.SetParamSimple(map, prefix + "BackupGiveUpData", this.BackupGiveUpData);
            this.SetParamSimple(map, prefix + "HasServicesLog", this.HasServicesLog);
            this.SetParamSimple(map, prefix + "KeepFailureLog", this.KeepFailureLog);
            this.SetParamSimple(map, prefix + "FailureLogKey", this.FailureLogKey);
            this.SetParamArrayObj(map, prefix + "DataTransformSqlDataSources.", this.DataTransformSqlDataSources);
            this.SetParamArrayObj(map, prefix + "EnvInfos.", this.EnvInfos);
        }
    }
}

