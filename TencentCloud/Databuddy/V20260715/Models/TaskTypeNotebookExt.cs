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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskTypeNotebookExt : AbstractModel
    {
        
        /// <summary>
        /// <p>SCRIPT SOURCE. Value: SCRIPT_SOURCE_LOCAL (LOCAL) / SCRIPT_SOURCE_GIT (GIT repository) /<br>SCRIPT_SOURCE_CFS (CFS file system) / SCRIPT_SOURCE_COS (cloud object storage) /<br>SCRIPT_SOURCE_WORKSPACE (WORKSPACE)</p>
        /// </summary>
        [JsonProperty("Source")]
        [System.Obsolete]
        public string Source{ get; set; }

        /// <summary>
        /// <p>For frontend display usage, meaningless to the execution platform</p>
        /// </summary>
        [JsonProperty("DisplayPath")]
        [System.Obsolete]
        public string DisplayPath{ get; set; }

        /// <summary>
        /// <p>Notebook relative path</p>
        /// </summary>
        [JsonProperty("NotebookPath")]
        [System.Obsolete]
        public string NotebookPath{ get; set; }

        /// <summary>
        /// <p>Notebook absolute path</p>
        /// </summary>
        [JsonProperty("NotebookAbsolutePath")]
        [System.Obsolete]
        public string NotebookAbsolutePath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "DisplayPath", this.DisplayPath);
            this.SetParamSimple(map, prefix + "NotebookPath", this.NotebookPath);
            this.SetParamSimple(map, prefix + "NotebookAbsolutePath", this.NotebookAbsolutePath);
        }
    }
}

