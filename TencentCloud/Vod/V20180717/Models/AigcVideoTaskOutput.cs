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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AigcVideoTaskOutput : AbstractModel
    {
        
        /// <summary>
        /// <p>Output file info of the AIGC video task.</p>
        /// </summary>
        [JsonProperty("FileInfos")]
        public AigcVideoTaskOutputFileInfo[] FileInfos{ get; set; }

        /// <summary>
        /// <p>The task ID of the task type Procedure. If a task flow template (Procedure) is specified when initiating <a href="https://www.tencentcloud.com/document/product/266/126239?from_cn_redirect=1">AIGC video task creation</a>, the task is initiated when the task flow template specifies one or more of MediaProcessTask, AiAnalysisTask, or AiRecognitionTask.</p>
        /// </summary>
        [JsonProperty("ProcedureTaskIds")]
        public string[] ProcedureTaskIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "FileInfos.", this.FileInfos);
            this.SetParamArraySimple(map, prefix + "ProcedureTaskIds.", this.ProcedureTaskIds);
        }
    }
}

