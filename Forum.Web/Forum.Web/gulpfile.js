var gulp = require('gulp'),
    less = require('gulp-less'),
    sourcemaps = require("gulp-sourcemaps"),
    LessPluginAutoPrefix = require('less-plugin-autoprefix'),
    autoprefix = new LessPluginAutoPrefix({ browsers: ["last 2 versions"] });

//gulp.task('bootstrap', function () {
//    return gulp.src('content/components/bootstrap/less/bootstrap.less')
//        .pipe(sourcemaps.init())  // Process the original sources
//        .pipe(less({
//            plugins: [autoprefix]
//        })).on('error', errorAlert)
//        .pipe(sourcemaps.write('./')) // Add the map to modified source.
//        .pipe(gulp.dest('content/css/'));
//});

gulp.task('fontawesome', function () {
    return gulp.src('content/components/font-awesome/less/font-awesome.less')
        .pipe(sourcemaps.init())  // Process the original sources
        .pipe(less({
            plugins: [autoprefix]
        })).on('error', errorAlert)
        .pipe(sourcemaps.write('./')) // Add the map to modified source.
        .pipe(gulp.dest('content/css/'));
});

gulp.task('main', function () {
    return gulp.src('content/less/main.less')
        .pipe(sourcemaps.init())  // Process the original sources
        .pipe(less({
            plugins: [autoprefix]
        })).on('error', errorAlert)
        .pipe(sourcemaps.write('./')) // Add the map to modified source.
        .pipe(gulp.dest('content/css/'));
});

//gulp.task("watch-bootstrap", function () {
//    gulp.watch("content/components/bootstrap/less/**/*.less", ["bootstrap"]);
//});

gulp.task("watch-main", function () {
    return gulp.watch("content/less/**/*.less", ["main"]);
});

gulp.task("default", [ "main", "watch-main"])

function errorAlert(err) {
    console.log(err.toString());
    this.emit("end");
}