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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModelInfo : AbstractModel
    {
        
        /// <summary>
        /// The model version ID is returned by the DescribeTrainingModelVersion API when querying the model.Enter the task ID of the Automated Machine Learning (AutoML) model.
        /// </summary>
        [JsonProperty("ModelVersionId")]
        public string ModelVersionId{ get; set; }

        /// <summary>
        /// Model ID.
        /// </summary>
        [JsonProperty("ModelId")]
        public string ModelId{ get; set; }

        /// <summary>
        /// Model name.
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// Model version.
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// Model source.
        /// </summary>
        [JsonProperty("ModelSource")]
        public string ModelSource{ get; set; }

        /// <summary>
        /// COS path information.
        /// </summary>
        [JsonProperty("CosPathInfo")]
        public CosPathInfo CosPathInfo{ get; set; }

        /// <summary>
        /// GooseFSx configurations, and is valid when ModelSource is GooseFSx.
        /// </summary>
        [JsonProperty("GooseFSx")]
        public GooseFSx GooseFSx{ get; set; }

        /// <summary>
        /// Algorithm framework corresponding to the model (reserved field).Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AlgorithmFramework")]
        public string AlgorithmFramework{ get; set; }

        /// <summary>
        /// Default: NORMAL; accelerated model: ACCELERATE; automatic learning model: AUTO_ML.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ModelType")]
        public string ModelType{ get; set; }

        /// <summary>
        /// Model format.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ModelFormat")]
        public string ModelFormat{ get; set; }

        /// <summary>
        /// Whether it is a private LLM.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsPrivateModel")]
        public bool? IsPrivateModel{ get; set; }

        /// <summary>
        /// Model category. Valid values: MultiModal (multi-modal) and LLM (text LLM).
        /// </summary>
        [JsonProperty("ModelCategory")]
        public string ModelCategory{ get; set; }

        /// <summary>
        /// Data source configurations.
        /// </summary>
        [JsonProperty("PublicDataSource")]
        public PublicDataSourceFS PublicDataSource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelVersionId", this.ModelVersionId);
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ModelVersion", this.ModelVersion);
            this.SetParamSimple(map, prefix + "ModelSource", this.ModelSource);
            this.SetParamObj(map, prefix + "CosPathInfo.", this.CosPathInfo);
            this.SetParamObj(map, prefix + "GooseFSx.", this.GooseFSx);
            this.SetParamSimple(map, prefix + "AlgorithmFramework", this.AlgorithmFramework);
            this.SetParamSimple(map, prefix + "ModelType", this.ModelType);
            this.SetParamSimple(map, prefix + "ModelFormat", this.ModelFormat);
            this.SetParamSimple(map, prefix + "IsPrivateModel", this.IsPrivateModel);
            this.SetParamSimple(map, prefix + "ModelCategory", this.ModelCategory);
            this.SetParamObj(map, prefix + "PublicDataSource.", this.PublicDataSource);
        }
    }
}

