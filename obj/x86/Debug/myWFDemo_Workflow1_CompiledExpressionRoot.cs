namespace myWFDemo {
    
    #line 36 "C:\Users\KathleenWest\Dropbox\Career\C# .NET\portfolio\CSharp\(WF) Windows Workflow Foundation\byte format sequencer\myWFDemo\myWFDemo\Workflow1.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\KathleenWest\Dropbox\Career\C# .NET\portfolio\CSharp\(WF) Windows Workflow Foundation\byte format sequencer\myWFDemo\myWFDemo\Workflow1.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 37 "C:\Users\KathleenWest\Dropbox\Career\C# .NET\portfolio\CSharp\(WF) Windows Workflow Foundation\byte format sequencer\myWFDemo\myWFDemo\Workflow1.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\KathleenWest\Dropbox\Career\C# .NET\portfolio\CSharp\(WF) Windows Workflow Foundation\byte format sequencer\myWFDemo\myWFDemo\Workflow1.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\KathleenWest\Dropbox\Career\C# .NET\portfolio\CSharp\(WF) Windows Workflow Foundation\byte format sequencer\myWFDemo\myWFDemo\Workflow1.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\KathleenWest\Dropbox\Career\C# .NET\portfolio\CSharp\(WF) Windows Workflow Foundation\byte format sequencer\myWFDemo\myWFDemo\Workflow1.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 38 "C:\Users\KathleenWest\Dropbox\Career\C# .NET\portfolio\CSharp\(WF) Windows Workflow Foundation\byte format sequencer\myWFDemo\myWFDemo\Workflow1.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 39 "C:\Users\KathleenWest\Dropbox\Career\C# .NET\portfolio\CSharp\(WF) Windows Workflow Foundation\byte format sequencer\myWFDemo\myWFDemo\Workflow1.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 40 "C:\Users\KathleenWest\Dropbox\Career\C# .NET\portfolio\CSharp\(WF) Windows Workflow Foundation\byte format sequencer\myWFDemo\myWFDemo\Workflow1.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\KathleenWest\Dropbox\Career\C# .NET\portfolio\CSharp\(WF) Windows Workflow Foundation\byte format sequencer\myWFDemo\myWFDemo\Workflow1.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class Workflow1 : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
        private System.Activities.Activity rootActivity;
        
        private object dataContextActivities;
        
        private bool forImplementation = true;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string GetLanguage() {
            return "C#";
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((this.dataContextActivities == null)) {
                this.dataContextActivities = Workflow1_TypedDataContext0_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext0_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow1_TypedDataContext0_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext0_ForReadOnly valDataContext0 = ((Workflow1_TypedDataContext0_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext0_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow1_TypedDataContext0_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext0_ForReadOnly valDataContext1 = ((Workflow1_TypedDataContext0_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow1_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext1_ForReadOnly valDataContext2 = ((Workflow1_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow1_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext1_ForReadOnly valDataContext3 = ((Workflow1_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext1.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Workflow1_TypedDataContext1(locations, activityContext, true);
                }
                Workflow1_TypedDataContext1 refDataContext4 = ((Workflow1_TypedDataContext1)(cachedCompiledDataContext[2]));
                return refDataContext4.GetLocation<decimal>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow1_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext1_ForReadOnly valDataContext5 = ((Workflow1_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext1.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Workflow1_TypedDataContext1(locations, activityContext, true);
                }
                Workflow1_TypedDataContext1 refDataContext6 = ((Workflow1_TypedDataContext1)(cachedCompiledDataContext[2]));
                return refDataContext6.GetLocation<int>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow1_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext1_ForReadOnly valDataContext7 = ((Workflow1_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 3);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow1_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext1_ForReadOnly valDataContext8 = ((Workflow1_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext8.ValueType___Expr8Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.Location> locations) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((expressionId == 0)) {
                Workflow1_TypedDataContext0_ForReadOnly valDataContext0 = new Workflow1_TypedDataContext0_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                Workflow1_TypedDataContext0_ForReadOnly valDataContext1 = new Workflow1_TypedDataContext0_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                Workflow1_TypedDataContext1_ForReadOnly valDataContext2 = new Workflow1_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                Workflow1_TypedDataContext1_ForReadOnly valDataContext3 = new Workflow1_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                Workflow1_TypedDataContext1 refDataContext4 = new Workflow1_TypedDataContext1(locations, true);
                return refDataContext4.GetLocation<decimal>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set);
            }
            if ((expressionId == 5)) {
                Workflow1_TypedDataContext1_ForReadOnly valDataContext5 = new Workflow1_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                Workflow1_TypedDataContext1 refDataContext6 = new Workflow1_TypedDataContext1(locations, true);
                return refDataContext6.GetLocation<int>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set);
            }
            if ((expressionId == 7)) {
                Workflow1_TypedDataContext1_ForReadOnly valDataContext7 = new Workflow1_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                Workflow1_TypedDataContext1_ForReadOnly valDataContext8 = new Workflow1_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "new string[] { \"B Bytes\", \"KB Kilobytes\", \"MB Megabytes\", \"GB Gigabytes\", \"TB Ter" +
                            "abytes\", \"PB Petabytes\", \"EB Exabytes\", \"ZB Zettabytes\", \"YB Yottabytes\", \"BB Br" +
                            "ontobytes\" }") 
                        && (Workflow1_TypedDataContext0_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "12345678") 
                        && (Workflow1_TypedDataContext0_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Input: \" + argInput.ToString()") 
                        && (Workflow1_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "argInput/1024") 
                        && (Workflow1_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "argInput") 
                        && (Workflow1_TypedDataContext1.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "count+1") 
                        && (Workflow1_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "count") 
                        && (Workflow1_TypedDataContext1.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "argInput > 1024") 
                        && (Workflow1_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "argInput.ToString(\"0.00\")+ unitName[count]") 
                        && (Workflow1_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            expressionId = -1;
            return false;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Collections.Generic.IList<string> GetRequiredLocations(int expressionId) {
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Linq.Expressions.Expression GetExpressionTreeForExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) {
            if ((expressionId == 0)) {
                return new Workflow1_TypedDataContext0_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new Workflow1_TypedDataContext0_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new Workflow1_TypedDataContext1_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new Workflow1_TypedDataContext1_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new Workflow1_TypedDataContext1(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new Workflow1_TypedDataContext1_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new Workflow1_TypedDataContext1(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new Workflow1_TypedDataContext1_ForReadOnly(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new Workflow1_TypedDataContext1_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 28 "C:\USERS\KATHLEENWEST\DROPBOX\CAREER\C# .NET\PORTFOLIO\CSHARP\(WF) WINDOWS WORKFLOW FOUNDATION\BYTE FORMAT SEQUENCER\MYWFDEMO\MYWFDEMO\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string[]>> expression = () => 
      new string[] { "B Bytes", "KB Kilobytes", "MB Megabytes", "GB Gigabytes", "TB Terabytes", "PB Petabytes", "EB Exabytes", "ZB Zettabytes", "YB Yottabytes", "BB Brontobytes" };
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string[] @__Expr0Get() {
                
                #line 28 "C:\USERS\KATHLEENWEST\DROPBOX\CAREER\C# .NET\PORTFOLIO\CSHARP\(WF) WINDOWS WORKFLOW FOUNDATION\BYTE FORMAT SEQUENCER\MYWFDEMO\MYWFDEMO\WORKFLOW1.XAML"
                return 
      new string[] { "B Bytes", "KB Kilobytes", "MB Megabytes", "GB Gigabytes", "TB Terabytes", "PB Petabytes", "EB Exabytes", "ZB Zettabytes", "YB Yottabytes", "BB Brontobytes" };
                
                #line default
                #line hidden
            }
            
            public string[] ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 23 "C:\USERS\KATHLEENWEST\DROPBOX\CAREER\C# .NET\PORTFOLIO\CSHARP\(WF) WINDOWS WORKFLOW FOUNDATION\BYTE FORMAT SEQUENCER\MYWFDEMO\MYWFDEMO\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
      12345678;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr1Get() {
                
                #line 23 "C:\USERS\KATHLEENWEST\DROPBOX\CAREER\C# .NET\PORTFOLIO\CSHARP\(WF) WINDOWS WORKFLOW FOUNDATION\BYTE FORMAT SEQUENCER\MYWFDEMO\MYWFDEMO\WORKFLOW1.XAML"
                return 
      12345678;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext1 : Workflow1_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int count;
            
            protected decimal argInput;
            
            public Workflow1_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string[] unitName {
                get {
                    return ((string[])(this.GetVariableValue((1 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((1 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 73 "C:\USERS\KATHLEENWEST\DROPBOX\CAREER\C# .NET\PORTFOLIO\CSHARP\(WF) WINDOWS WORKFLOW FOUNDATION\BYTE FORMAT SEQUENCER\MYWFDEMO\MYWFDEMO\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
              argInput;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr4Get() {
                
                #line 73 "C:\USERS\KATHLEENWEST\DROPBOX\CAREER\C# .NET\PORTFOLIO\CSHARP\(WF) WINDOWS WORKFLOW FOUNDATION\BYTE FORMAT SEQUENCER\MYWFDEMO\MYWFDEMO\WORKFLOW1.XAML"
                return 
              argInput;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr4Set(decimal value) {
                
                #line 73 "C:\USERS\KATHLEENWEST\DROPBOX\CAREER\C# .NET\PORTFOLIO\CSHARP\(WF) WINDOWS WORKFLOW FOUNDATION\BYTE FORMAT SEQUENCER\MYWFDEMO\MYWFDEMO\WORKFLOW1.XAML"
                
              argInput = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr4Set(decimal value) {
                this.GetValueTypeValues();
                this.@__Expr4Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 85 "C:\USERS\KATHLEENWEST\DROPBOX\CAREER\C# .NET\PORTFOLIO\CSHARP\(WF) WINDOWS WORKFLOW FOUNDATION\BYTE FORMAT SEQUENCER\MYWFDEMO\MYWFDEMO\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
              count;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr6Get() {
                
                #line 85 "C:\USERS\KATHLEENWEST\DROPBOX\CAREER\C# .NET\PORTFOLIO\CSHARP\(WF) WINDOWS WORKFLOW FOUNDATION\BYTE FORMAT SEQUENCER\MYWFDEMO\MYWFDEMO\WORKFLOW1.XAML"
                return 
              count;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr6Set(int value) {
                
                #line 85 "C:\USERS\KATHLEENWEST\DROPBOX\CAREER\C# .NET\PORTFOLIO\CSHARP\(WF) WINDOWS WORKFLOW FOUNDATION\BYTE FORMAT SEQUENCER\MYWFDEMO\MYWFDEMO\WORKFLOW1.XAML"
                
              count = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr6Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr6Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.count = ((int)(this.GetVariableValue((0 + locationsOffset))));
                this.argInput = ((decimal)(this.GetVariableValue((2 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((0 + locationsOffset), this.count);
                this.SetVariableValue((2 + locationsOffset), this.argInput);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 1)].Name != "unitName") 
                            || (locationReferences[(offset + 1)].Type != typeof(string[])))) {
                    return false;
                }
                if (((locationReferences[(offset + 0)].Name != "count") 
                            || (locationReferences[(offset + 0)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "argInput") 
                            || (locationReferences[(offset + 2)].Type != typeof(decimal)))) {
                    return false;
                }
                return Workflow1_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext1_ForReadOnly : Workflow1_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int count;
            
            protected decimal argInput;
            
            public Workflow1_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string[] unitName {
                get {
                    return ((string[])(this.GetVariableValue((1 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 62 "C:\USERS\KATHLEENWEST\DROPBOX\CAREER\C# .NET\PORTFOLIO\CSHARP\(WF) WINDOWS WORKFLOW FOUNDATION\BYTE FORMAT SEQUENCER\MYWFDEMO\MYWFDEMO\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
        "Input: " + argInput.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr2Get() {
                
                #line 62 "C:\USERS\KATHLEENWEST\DROPBOX\CAREER\C# .NET\PORTFOLIO\CSHARP\(WF) WINDOWS WORKFLOW FOUNDATION\BYTE FORMAT SEQUENCER\MYWFDEMO\MYWFDEMO\WORKFLOW1.XAML"
                return 
        "Input: " + argInput.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 78 "C:\USERS\KATHLEENWEST\DROPBOX\CAREER\C# .NET\PORTFOLIO\CSHARP\(WF) WINDOWS WORKFLOW FOUNDATION\BYTE FORMAT SEQUENCER\MYWFDEMO\MYWFDEMO\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<decimal>> expression = () => 
              argInput/1024;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public decimal @__Expr3Get() {
                
                #line 78 "C:\USERS\KATHLEENWEST\DROPBOX\CAREER\C# .NET\PORTFOLIO\CSHARP\(WF) WINDOWS WORKFLOW FOUNDATION\BYTE FORMAT SEQUENCER\MYWFDEMO\MYWFDEMO\WORKFLOW1.XAML"
                return 
              argInput/1024;
                
                #line default
                #line hidden
            }
            
            public decimal ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 90 "C:\USERS\KATHLEENWEST\DROPBOX\CAREER\C# .NET\PORTFOLIO\CSHARP\(WF) WINDOWS WORKFLOW FOUNDATION\BYTE FORMAT SEQUENCER\MYWFDEMO\MYWFDEMO\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
              count+1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr5Get() {
                
                #line 90 "C:\USERS\KATHLEENWEST\DROPBOX\CAREER\C# .NET\PORTFOLIO\CSHARP\(WF) WINDOWS WORKFLOW FOUNDATION\BYTE FORMAT SEQUENCER\MYWFDEMO\MYWFDEMO\WORKFLOW1.XAML"
                return 
              count+1;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 67 "C:\USERS\KATHLEENWEST\DROPBOX\CAREER\C# .NET\PORTFOLIO\CSHARP\(WF) WINDOWS WORKFLOW FOUNDATION\BYTE FORMAT SEQUENCER\MYWFDEMO\MYWFDEMO\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
        argInput > 1024;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr7Get() {
                
                #line 67 "C:\USERS\KATHLEENWEST\DROPBOX\CAREER\C# .NET\PORTFOLIO\CSHARP\(WF) WINDOWS WORKFLOW FOUNDATION\BYTE FORMAT SEQUENCER\MYWFDEMO\MYWFDEMO\WORKFLOW1.XAML"
                return 
        argInput > 1024;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 98 "C:\USERS\KATHLEENWEST\DROPBOX\CAREER\C# .NET\PORTFOLIO\CSHARP\(WF) WINDOWS WORKFLOW FOUNDATION\BYTE FORMAT SEQUENCER\MYWFDEMO\MYWFDEMO\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
        argInput.ToString("0.00")+ unitName[count];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr8Get() {
                
                #line 98 "C:\USERS\KATHLEENWEST\DROPBOX\CAREER\C# .NET\PORTFOLIO\CSHARP\(WF) WINDOWS WORKFLOW FOUNDATION\BYTE FORMAT SEQUENCER\MYWFDEMO\MYWFDEMO\WORKFLOW1.XAML"
                return 
        argInput.ToString("0.00")+ unitName[count];
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            protected override void GetValueTypeValues() {
                this.count = ((int)(this.GetVariableValue((0 + locationsOffset))));
                this.argInput = ((decimal)(this.GetVariableValue((2 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 1)].Name != "unitName") 
                            || (locationReferences[(offset + 1)].Type != typeof(string[])))) {
                    return false;
                }
                if (((locationReferences[(offset + 0)].Name != "count") 
                            || (locationReferences[(offset + 0)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "argInput") 
                            || (locationReferences[(offset + 2)].Type != typeof(decimal)))) {
                    return false;
                }
                return Workflow1_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
